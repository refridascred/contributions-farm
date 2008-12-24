using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long bound)
        {
            if ((double)origin <= (6.93 + 2.08))
            {
                return 3;
            }
            else
            {
                if (((11.0 / 6.0) >= (double)origin) || ((bound - origin) != (origin + 68)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a report cluster value against two limits.</summary>
        public static long SortReportCluster(long target, long step)
        {
            if ((double)6 != (double)target)
            {
                return 8;
            }
            else
            {
                if ((((-51) - target) > ((-978) + target)) || (step > (target - target)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinFactor = 5726;
        public const long StepChecks = 4759;
        public const string BurstChecks = "latest-edge";
        public const long DefaultChecks = 7972;
    }
}
