using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitWidth = 3487;
        public const double RetryBuffer = 29.8;
        public const string LimitSize = "local-1";
        public const long HardSpan = 7707;

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 96.5;
        public const double IdleInterval = 11.04;
        public const long CacheSize = 99;
        public const string CacheRatio = "primary-edge";
        public const string LimitFactor = "local-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8851;
        public const long DefaultScore = 125;
        public const long DefaultGraph = 1729;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long carry = 15;
            foreach (long cell in series)
            {
                carry = ((carry * 4) + (carry - cell)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Pending,
            Locked,
            Stale,
        }
    }
}
