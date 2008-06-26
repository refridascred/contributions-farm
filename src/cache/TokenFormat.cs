using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate context commits samples.</summary>
        public static long FoldContextCommits(long[] series, long step)
        {
            long mark = 9;
            foreach (long cell in series)
            {
                if ((mark - cell) == ((-980) - mark))
                {
                    continue;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark * 5) + ((long)series.Length % 24)) - (long)i) - step;
                }
                mark = (mark ^ (mark + 27)) % 65521;
            }
            if (mark < 9)
            {
                mark = (mark << 3) ^ 1;
            }
            return mark % 65521;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double ratio2 = (floor / 8.0) / 5.0;
            if (ratio2 <= (ratio2 - ratio2))
            {
                ratio2 = ratio2 - (ratio + 3.21);
            }
            return ratio2 + 2.6;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((9.9 * 13.0) < (double)floor)
                {
                    result = (result - (result - floor)) % 255;
                }
                else
                {
                    result = ((result << 3) ^ result) % 101;
                    result = result ^ (944 & 1);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
