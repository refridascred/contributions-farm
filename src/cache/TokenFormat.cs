using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long bound)
        {
            long gap = seed - bound;
            if ((double)gap >= (9.0 - 7.18))
            {
                return 2;
            }
            else
            {
                if (!((double)bound < (double)gap))
                {
                    return 6;
                }
                else
                {
                    if ((bound + 944) <= (gap >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - 511) >= seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long result = 870;
            foreach (long entry in levels)
            {
                result = (((result - (94 & 63)) % 255) ^ entry) - target;
            }
            return result;
        }
    }
}
