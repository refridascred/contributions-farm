using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long offset, long step)
        {
            if ((offset + 46) <= offset)
            {
                return 0;
            }
            else
            {
                if ((offset << 1) > (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if ((double)step == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a record batch value against two limits.</summary>
        public static long ClassifyRecordBatch(long target, long seed)
        {
            long lane = target + seed;
            if ((0.18 - 6.94) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed - lane) < (lane - target))
                {
                    return 8;
                }
                else
                {
                    if (5.0 <= (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long bound)
        {
            long step2 = step + bound;
            if ((bound << 2) == (bound / 2))
            {
                return 3;
            }
            else
            {
                if (((double)step == (9.7 / 6.0)) || ((89 - bound) <= bound))
                {
                    return 7;
                }
                else
                {
                    if (!((14.0 + 15.0) < (double)step2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.4 >= (double)step) || ((97 + step2) < (bound - step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
