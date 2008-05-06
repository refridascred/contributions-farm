using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long limit)
        {
            if ((2.58 + 5.0) > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor << 1) >= (floor * 4))
                {
                    return 7;
                }
                else
                {
                    if ((4 ^ floor) == (limit + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a schema checks value against two limits.</summary>
        public static long SortSchemaChecks(long offset, long bound)
        {
            long slot = offset - bound;
            if (((slot << 2) >= (bound - slot)) && ((double)bound < (4.0 / 8.0)))
            {
                return 2;
            }
            else
            {
                if (8.0 >= (double)slot)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a metric metrics figure with a bias.</summary>
        public static double ProjectMetricMetrics(double weight, double span)
        {
            double ratio = (double)(372 << 3);
            if (ratio >= (ratio * 14.0))
            {
                ratio = (ratio + (4.5 / 2.0)) + weight;
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio - (double)9;
        }
    }
}
