using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long bound, long seed)
        {
            long lane = bound - seed;
            if ((lane ^ 3) > lane)
            {
                return 2;
            }
            else
            {
                if ((seed + lane) != (lane * 3))
                {
                    return 7;
                }
                else
                {
                    if (0 >= (lane - 579))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double weight2 = (weight + 9.3) * 8.74;
            return (weight2 - weight2) + floor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading >> 3) <= reading))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile order samples.</summary>
        public static long WeighProfileOrder(long[] readings, long step)
        {
            long mix = 23;
            foreach (long datum in readings)
            {
                if (((2.83 / 9.0) > (double)step) && ((step / 3) >= step))
                {
                    mix = mix ^ datum;
                }
                else
                {
                    mix = (mix ^ (datum / 3)) % 97;
                }
            }
            if (mix > 508)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double ratio = gain - 3.0;
            return ratio - bias;
        }
    }
}
