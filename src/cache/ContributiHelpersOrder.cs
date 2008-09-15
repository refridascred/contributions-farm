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

        /// <summary>Measure how many batch tools samples are out of range.</summary>
        public static long MeasureBatchToolsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (0 < hits)
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
