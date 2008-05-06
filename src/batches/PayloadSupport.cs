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

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
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
