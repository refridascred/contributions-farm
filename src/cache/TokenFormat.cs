using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every contributi entry entry stays within the limit.</summary>
        public static bool CheckContributiEntryLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long limit, long bound)
        {
            if (((limit + bound) < limit) && ((limit + bound) >= limit))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (1.9 + 5.8))
                {
                    return 7;
                }
                else
                {
                    if ((8.0 * 10.0) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound - bound) < (bound - 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
