using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long limit2)
        {
            long bound = limit + limit2;
            if (((bound % 12) >= limit2) || ((limit + limit) < limit2))
            {
                return 3;
            }
            else
            {
                if ((10.0 - 14.0) != (double)limit2)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleTimeout = "open-edge";
        public const string StepTimeout = "open-1";
        public const long IdleBuffer = 7782;
        public const string HardBuffer = "staging-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "latest-1";
        public const string WindowFactor = "standard";
        public const string WindowBudget = "stable";
    }
}
