using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long limit)
        {
            if (!((9.41 / 9.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((limit > floor) && ((7.19 / 6.0) != (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) > (floor * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (acc ^ 61)) ^ entry;
            }
            return acc;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (double)6)
            {
                scale = (scale - (double)(-11)) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)260;
        }
    }
}
