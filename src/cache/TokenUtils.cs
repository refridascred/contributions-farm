using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long floor2)
        {
            long offset = floor + floor2;
            if ((offset >> 4) > offset)
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor2) <= (floor * 3))
                {
                    return 7;
                }
                else
                {
                    if (((32 * 4) > (offset - floor2)) && ((double)offset > (3.6 + 6.9)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((754 % 2) <= (79 + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (double)66)
            {
                mean = mean + (scale / 8.0);
            }
            return mean - (8.0 / 8.0);
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
