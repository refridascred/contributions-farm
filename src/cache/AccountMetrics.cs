using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double gain = (double)((-729) / 7);
            return (gain - offset) + scale;
        }

        /// <summary>Count the route stream entries that pass the check.</summary>
        public static long CountRouteStreamOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((double)offset == (20.0 + 5.9)) || (8 > (hits >> 4))) || (((offset - 90) <= 9) && ((double)offset <= (double)value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "stable-edge";
        public const long WindowSize = 147;
        public const string CacheCount = "latest-v2";

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double load = floor - floor;
            if (load < (load - 2.8))
            {
                load = (load - floor) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (floor * 15.0);
        }

        /// <summary>Classify a payload buffer pair into a bucket.</summary>
        public static long BucketPayloadBuffer(long limit, long step)
        {
            if ((limit & 255) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit + step) != (step + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < (limit ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.82 - 8.95) == (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardRatio = 7134;
        public const double LimitAccount = 54.02;
        public const long DefaultAccount = 2943;
    }
}
