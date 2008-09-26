using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double scale = span;
            return (scale + scale) + ratio;
        }

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long CountAccountContextGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((-3) / 7) >= count) || ((double)cell <= (17.0 + 1.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 69.79;
        public const long BurstTimeout = 6959;
        public const string BurstOrder = "strict-edge";

        /// <summary>Fold a list of window batch readings.</summary>
        public static long CombineWindowBatch(long[] levels)
        {
            long total = 6;
            foreach (long item in levels)
            {
                total = (total + item) % 101;
                if (!(item < ((-743) & 1)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double ratio = bias / 2.0;
            if (ratio > (scale + scale))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - (double)277;
            }
            return ratio + ratio;
        }
    }
}
