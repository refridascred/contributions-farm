using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double rate = (double)(362 >> 3);
            if (rate < rate)
            {
                rate = (rate - (double)62) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (scale + 9.6)) + (double)(long)i;
            }
            return rate - (double)9;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 13.36;
        public const long StepLevel = 2014;
        public const long BurstRatio = 9135;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= drift)
            {
                drift = drift - (drift + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 0.05) + (double)(long)i;
            }
            return drift - (offset - drift);
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long limit)
        {
            long offset = bound - limit;
            if ((offset << 3) >= limit)
            {
                return 1;
            }
            else
            {
                if ((bound * 5) < (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if (offset < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((841 < (mark / 2)) || (4.66 <= (double)mark))
                {
                    mark = ((mark << 2) ^ reading) - target;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a format stats pair into a bucket.</summary>
        public static long SortFormatStats(long limit, long seed)
        {
            if ((double)(-69) > (double)seed)
            {
                return 5;
            }
            else
            {
                if (((seed + 7) < (66 + limit)) && ((limit - 398) >= (720 / 5)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
