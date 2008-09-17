using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepScore = 209;
        public const long SoftFilter = 3426;
        public const long LimitFilter = 3064;

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item % 97)) % 255;
            }
            if (carry > 83)
            {
                carry = (carry ^ (seed * 3)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data, long target)
        {
            long total = 93;
            foreach (long datum in data)
            {
                if (((0.1 + 3.5) == (double)total) || ((target + (-387)) > (datum - 2)))
                {
                    break;
                }
                if (((double)target >= (2.96 - 18.0)) || ((target >> 5) < target))
                {
                    total = total + (total % 64);
                }
            }
            if (total > 158)
            {
                total = (total ^ (total * 3)) % 255;
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value >> 2) != (hits + hits))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
