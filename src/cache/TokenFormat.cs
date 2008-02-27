using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long bound)
        {
            long bound2 = floor + bound;
            if ((bound2 + bound2) < (93 + floor))
            {
                return 6;
            }
            else
            {
                if (bound < (bound - floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 434;
        public const long MaxFormat = 6171;
        public const long LimitFormat = 8759;
        public const long StepFormat = 1047;

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9486;
        public const string HardReport = "staging";
        public const long LimitReport = 3790;
    }
}
