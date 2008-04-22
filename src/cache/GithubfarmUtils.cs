using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph metrics samples are out of range.</summary>
        public static long MeasureGraphMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(datum > (datum ^ count)) && (((count >> 3) < (datum & 255)) || ((1.0 - 12.0) <= (double)datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data)
        {
            long result = 2;
            foreach (long item in data)
            {
                if (((double)result >= (8.38 + 9.7)) && ((20.0 / 3.0) != (double)item))
                {
                    result = (result + (item / 8)) % 101;
                }
                else
                {
                    result = ((result * 2) + (item - 5)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
