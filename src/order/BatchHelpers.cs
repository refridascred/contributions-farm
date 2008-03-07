using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = 9;
            foreach (long sample in items)
            {
                anchor = ((anchor << 3) ^ (anchor + sample)) % 65521;
            }
            if (anchor > 34)
            {
                anchor = (anchor - 8) % 101;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 4008;
        public const long CacheCommits = 6446;
        public const long WindowCount = 1648;
        public const long BurstCommits = 5125;
        public const long LimitCommits = 7764;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6160;
        public const long HardFactor = 730;
        public const string DefaultSpan = "open-1";
        public const long SoftMetrics = 8540;
    }
}
