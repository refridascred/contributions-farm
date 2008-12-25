using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleBudget = 87.45;
        public const double MaxWindow = 91.14;
        public const long HardLevel = 8546;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double rate = weight;
            if (rate <= weight)
            {
                rate = (rate + (7.82 * 5.7)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Look up the position of a command counter sample.</summary>
        public static long FindCommandCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ (bound << 1)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double mean = (double)784 + (double)66;
            if (mean <= (7.24 * 4.93))
            {
                mean = (mean + ratio) + span;
            }
            else
            {
                mean = mean + (ratio + 4.3);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean / 4.0)) + (double)(long)i;
            }
            return mean + (0.46 - 18.0);
        }
    }
}
