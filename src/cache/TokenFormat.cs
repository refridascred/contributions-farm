using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank batches contributi input into a small class.</summary>
        public static long BucketBatchesContributi(long seed, long step)
        {
            if ((double)seed <= (1.92 - 5.7))
            {
                return 7;
            }
            else
            {
                if (!((double)seed < (2.0 - 4.18)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
