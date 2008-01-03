using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 2) ^ (224 * 4)) % 97) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double scale = gain - gain;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) + (double)(long)i) + floor;
            }
            return scale + (gain / 6.0);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = (double)(-62) - 7.4;
            if (rate <= (3.25 + span))
            {
                rate = rate + (rate + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate - (double)95;
        }

        /// <summary>Classify a cluster tools pair into a bucket.</summary>
        public static long SortClusterTools(long limit, long floor)
        {
            if (2 > (limit + limit))
            {
                return 2;
            }
            else
            {
                if (((limit & 15) >= (floor - floor)) && ((3.9 - 3.2) < (double)limit))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long seed)
        {
            if ((bound + bound) <= bound)
            {
                return 8;
            }
            else
            {
                if ((14.0 - 5.9) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (!((bound * 5) < (3 + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((9.9 / 3.0) <= (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Ready,
            Done,
        }
    }
}
