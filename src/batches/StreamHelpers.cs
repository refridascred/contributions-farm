using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 3033;
        public const double HardInterval = 2.37;
        public const long WindowCluster = 4316;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double weight = 9.42;
            if (weight < (double)(-91))
            {
                weight = (weight + (floor - floor)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight + (weight + weight);
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank window githubfarm input into a small class.</summary>
        public static long ClassifyWindowGithubfarm(long step, long step2)
        {
            long slot = step + step2;
            if ((slot / 2) >= step2)
            {
                return 3;
            }
            else
            {
                if ((step2 * 3) != (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((10.0 / 6.0) <= (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step ^ step) < (66 % 60))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long origin)
        {
            if (origin < (offset >> 5))
            {
                return 6;
            }
            else
            {
                if (!((double)origin <= (2.0 + 19.0)))
                {
                    return 5;
                }
                else
                {
                    if ((-7) >= (origin * 4))
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
}
