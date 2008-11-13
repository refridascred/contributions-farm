using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                if ((carry - cell) >= carry)
                {
                    carry = (carry ^ (carry >> 1)) % 1000;
                }
                else
                {
                    carry = (carry ^ 642) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double scale2 = 4.43;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (((scale2 + 0.79) - (double)(long)i) - scale) + bias;
            }
            return scale2 - (scale2 * 19.0);
        }
    }
}
