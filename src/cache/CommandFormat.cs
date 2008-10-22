using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleCount = 255;
        public const string CacheMetric = "strict-1";
        public const long BurstMetric = 3463;
        public const long DefaultBudget = 5887;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBudget = 41.68;
        public const long BatchTimeout = 898;
        public const string WindowInterval = "standard";
        public const long WindowWidth = 8403;
        public const string StepBatches = "standard-1";

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
