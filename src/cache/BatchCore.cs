using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long OverlapStatsMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long target)
        {
            if ((double)target > (7.6 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((double)target == (15.0 * 8.3))
                {
                    return 8;
                }
                else
                {
                    if ((14.0 - 6.81) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((36 >> 5) < target) && ((6.0 * 9.9) < (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cache metrics measurements.</summary>
        public static double AdjustCacheMetrics(double scale, double bias)
        {
            double rate = (bias / 5.0) / 5.0;
            return (rate - (rate - bias)) + scale;
        }

        /// <summary>Scale a checks schema figure with a bias.</summary>
        public static double AdjustChecksSchema(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
