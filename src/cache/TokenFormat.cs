using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long limit2)
        {
            if ((limit2 / 9) != (47 & 1))
            {
                return 4;
            }
            else
            {
                if ((limit2 / 5) >= (limit * 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 87.69;
        public const double RetryTimeout = 19.36;
        public const long MaxBudget = 5911;
        public const double SoftLevel = 58.24;
        public const double LimitSpan = 48.41;
    }
}
