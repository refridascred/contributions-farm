using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i ^ mix) >= ((long)i ^ (long)i)))
                {
                    mix = mix ^ (offset >> 5);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long bound, long floor)
        {
            if (!((bound - floor) <= (floor + bound)))
            {
                return 2;
            }
            else
            {
                if ((bound ^ bound) > (bound + 466))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 * 0.83) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor > (floor & 31)) || ((floor * 2) > (floor / 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long SeriesToolsCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + origin) % 101;
                if (!(((long)i ^ mix) > origin))
                {
                    mix = (mix ^ 737) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double drift = (double)((-84) - 4);
            if (drift >= (floor / 7.0))
            {
                drift = (drift - (floor + drift)) - gain;
            }
            return drift + (drift * 3.0);
        }
    }
}
