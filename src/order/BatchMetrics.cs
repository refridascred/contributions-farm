using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 24) > tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 6) >= bound)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((tally / 9) != (tally + tally)) || (sample < tally)) && ((sample % 24) != (497 << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
