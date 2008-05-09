using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate metric report samples.</summary>
        public static long ScoreMetricReport(long[] data, long floor)
        {
            long acc = 5;
            foreach (long sample in data)
            {
                if ((4.91 - 13.0) <= (double)floor)
                {
                    acc = (((acc << 2) ^ (floor << 3)) % 97) - sample;
                }
            }
            if (acc > 9)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
