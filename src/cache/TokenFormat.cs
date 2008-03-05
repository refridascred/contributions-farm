using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long limit)
        {
            long lane = target + limit;
            if ((target + target) > 8)
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((target > lane) || ((lane - 353) <= lane))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + lane) > (target - lane)) && ((double)limit > (17.0 * 8.3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session batches input into a small class.</summary>
        public static long RankSessionBatches(long floor, long limit)
        {
            if ((floor + floor) > limit)
            {
                return 7;
            }
            else
            {
                if ((690 / 9) >= (floor % 24))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (floor >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit == (14.0 + 4.0)) && ((double)limit > (1.15 * 6.91)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
