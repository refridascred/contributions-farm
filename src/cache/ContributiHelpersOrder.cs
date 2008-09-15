using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long bound)
        {
            long gap = offset + bound;
            if ((8.0 * 2.72) < (7.4 + 17.0))
            {
                return 0;
            }
            else
            {
                if (((offset << 3) > offset) && (4.21 <= (double)gap))
                {
                    return 4;
                }
                else
                {
                    if ((bound % 3) <= (offset % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)gap < (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long limit)
        {
            long gap = step ^ limit;
            if (!((limit & 7) < (gap + step)))
            {
                return 5;
            }
            else
            {
                if (((3.75 + 4.67) < (double)step) && (gap > (gap + gap)))
                {
                    return 7;
                }
                else
                {
                    if ((gap >= (step << 2)) && (limit >= (gap ^ 26)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((15.0 + 5.59) == (double)gap) || ((double)step >= 8.62))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long limit)
        {
            long score = 640;
            foreach (long sample in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    long diff = (score - limit) + (score + limit);
                    score = ((score << 3) ^ diff) + (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score + (5 - limit)) - (long)i2;
                }
                if (limit > (score >> 3))
                {
                    score = ((score << 3) ^ (sample / 8)) % 1000;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }
    }
}
