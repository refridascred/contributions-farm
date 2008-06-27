using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long seed, long bound)
        {
            if ((56 % 10) > bound)
            {
                return 2;
            }
            else
            {
                if (!((double)bound > 7.0))
                {
                    return 3;
                }
                else
                {
                    if (((seed + bound) <= (bound - bound)) || ((seed & 31) != (seed * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed >= (seed % 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 1015;
        public const double RetryWidth = 63.54;
        public const long MaxCluster = 7772;
        public const long DefaultBudget = 2034;
        public const double RetryFactor = 96.25;
    }
}
