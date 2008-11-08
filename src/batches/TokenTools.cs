using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long next = floor - seed;
            if (!((8.0 - 9.05) < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((next - floor) != (floor << 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 1064;
        public const long LimitSchema = 1317;
        public const string SoftSize = "fallback-1";
    }
}
