using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 13.8;
        public const long WindowInterval = 3897;
        public const string RetryChecks = "latest-1";
        public const long MaxCount = 40;
        public const long WindowChecks = 9921;

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 87.87;
        public const long StepRatio = 8173;
        public const string StepFactor = "local-edge";

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long bound)
        {
            long span = target ^ bound;
            if (((bound - span) <= (span ^ span)) || ((double)target == (1.22 - 8.6)))
            {
                return 0;
            }
            else
            {
                if (!((target % 7) >= (span - (-7))))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
