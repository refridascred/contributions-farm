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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
