using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a graph metric counter forward.</summary>
        public static long SeriesGraphMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed - seed) != (1 ^ (long)i))
                {
                    result = result + (seed - (long)i);
                }
                result = (result + seed) % 4096;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 255) <= (offset % 64))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
