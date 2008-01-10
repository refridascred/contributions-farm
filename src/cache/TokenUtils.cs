using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next route support value.</summary>
        public static double SmoothRouteSupport(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (bias * 9.8)) - (double)(long)i) - offset;
            }
            return bias - (scale + bias);
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long limit)
        {
            if ((double)limit <= (9.9 + 4.39))
            {
                return 3;
            }
            else
            {
                if ((floor - limit) != (floor << 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
