using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two batches token measurements.</summary>
        public static double ScaleBatchesToken(double bias, double span)
        {
            double mean = (double)(110 - 425);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - bias) - (double)(long)i) - span;
            }
            return mean + mean;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum - (long)items.Length) <= (19 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
