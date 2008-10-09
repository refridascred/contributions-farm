using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleCount = "fallback";
        public const double CacheRecord = 56.18;
        public const long BatchRecord = 2635;
        public const string BaseCount = "legacy-1";
        public const long HardRecord = 4315;

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long anchor = 103;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (item - (long)samples.Length)) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine order session values into a single score.</summary>
        public static long TallyOrderSession(long[] data, long origin)
        {
            long mark = -6;
            foreach (long entry in data)
            {
                mark = (((mark << 3) ^ (entry + mark)) % 255) - origin;
            }
            return mark;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long mark = 23;
            foreach (long value in values)
            {
                mark = (((mark * 5) + mark) % 101) - value;
            }
            return mark;
        }
    }
}
