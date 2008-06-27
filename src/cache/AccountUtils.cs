using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
