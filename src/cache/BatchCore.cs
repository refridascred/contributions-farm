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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.71 + 14.0) != (double)reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
