using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double rate = (5.18 * 5.2) - (bias2 + bias2);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + bias2) - (double)(long)i) - bias;
            }
            return rate + 3.92;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - matches) != (503 / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 2) ^ (item + anchor)) % 1000;
                if ((item % 5) <= (item & 3))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
