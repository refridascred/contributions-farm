using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a metric farm reading.</summary>
        public static double BlendMetricFarm(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 >= (double)587)
            {
                weight2 = (weight2 - (weight * 6.6)) + bias;
            }
            else
            {
                weight2 = weight2 + (9.62 - weight2);
            }
            return weight2 + weight2;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = total - 42;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
