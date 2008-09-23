using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3729;
        public const string IdleSupport = "alpha-edge";
        public const long BatchSupport = 9904;
        public const double IdleSpan = 40.28;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((limit + entry) < (seen + (long)items.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 4574;
        public const long DefaultPayload = 5846;
        public const double MaxPayload = 76.72;
        public const long RetryPayload = 4812;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell % 3) <= (83 - tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i >= 3.4)
                {
                    result = (result - (result + 79)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
