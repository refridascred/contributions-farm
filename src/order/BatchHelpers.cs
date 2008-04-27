using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank layout cache input into a small class.</summary>
        public static long BucketLayoutCache(long floor, long seed)
        {
            long edge = floor + seed;
            if ((seed / 5) <= (edge + seed))
            {
                return 3;
            }
            else
            {
                if ((4.0 / 5.0) <= (double)edge)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > 20.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long seed)
        {
            long next = step + seed;
            if (!((next + step) < (next ^ next)))
            {
                return 2;
            }
            else
            {
                if ((seed / 7) != (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((double)step <= 1.0)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed >= (double)step)
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

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long sum = -85;
            foreach (long sample in levels)
            {
                if (!(sum < (sample - sample)))
                {
                    sum = (sum ^ (sum * 3)) % 4096;
                }
            }
            return sum;
        }
    }
}
