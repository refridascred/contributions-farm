using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long offset)
        {
            long bound = limit ^ offset;
            if ((9.5 - 9.5) > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound - limit) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((limit << 3) < (91 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data)
        {
            long sum = 74;
            foreach (long sample in data)
            {
                if ((5.0 + 17.0) != (double)(long)data.Length)
                {
                    sum = (sum + 700) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values, long seed)
        {
            long mark = 936;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark ^ mark) % 1000) ^ (long)i;
                }
                if (((7 - value) < (mark + seed)) && ((double)seed <= 18.0))
                {
                    mark = (mark + (seed + value)) % 65521;
                }
                if ((seed & 7) == (2 + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
