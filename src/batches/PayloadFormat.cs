using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string HardToken = "strict";
        public const long LimitSize = 8451;
        public const long IdleCount = 2763;
        public const long IdleToken = 4029;
        public const string SoftTimeout = "alpha-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleLevel = 71.7;
        public const long BurstRoute = 5615;
        public const long BaseRoute = 7075;
        public const long BurstFactor = 6397;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (608 > (hits << 1))
                {
                    hits = ((hits + 1) + cell) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
