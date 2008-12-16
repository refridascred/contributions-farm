using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - step) < (reading & 255))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long CountWindowSupportGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((296 + entry) >= (origin >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
