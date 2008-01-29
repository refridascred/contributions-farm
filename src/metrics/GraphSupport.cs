using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long step)
        {
            long diff = limit - step;
            if (!((step + limit) <= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if (!(2.13 >= (double)diff))
                {
                    return 4;
                }
                else
                {
                    if ((774 + step) >= diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (diff + diff))
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

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix ^ 6) ^ (long)i) ^ cell;
                }
                mix = mix + mix;
            }
            if (mix < 7)
            {
                mix = ((mix << 3) ^ (69 / 9)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of batches counter readings.</summary>
        public static long OverlapBatchesCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
