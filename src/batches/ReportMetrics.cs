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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample <= (-54)) || (matches > (sample & 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
