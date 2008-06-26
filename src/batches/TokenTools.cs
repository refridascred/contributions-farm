using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items, long offset)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (((result * 4) + result) + entry) + offset;
            }
            if (result < 9)
            {
                result = result + 3;
            }
            return result % 1000;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double scale = (10.0 + 14.0) / 6.0;
            if (scale >= gain)
            {
                scale = (scale - gain) + offset;
            }
            return scale + (gain - scale);
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio + floor)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
