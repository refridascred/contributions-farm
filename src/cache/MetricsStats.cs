using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 9233;
        public const double MinAlready = 2.18;
        public const long BaseScore = 1322;

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            New,
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings)
        {
            long mix = 53;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ (5 / 5)) - entry;
            }
            return mix;
        }
    }
}
