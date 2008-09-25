using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two order window measurements.</summary>
        public static double ScaleOrderWindow(double scale, double bias)
        {
            double bias2 = (bias / 6.0) - bias;
            if (bias2 >= (17.0 + bias))
            {
                bias2 = (bias2 + bias) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)73) + (double)(long)i;
            }
            return bias2 - (4.0 + bias);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9 + offset) <= (hits % 100))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepSpan = 7650;
        public const long SoftRatio = 1603;
        public const long DefaultFilter = 2439;
        public const long IdleDepth = 1770;
        public const double SoftWidth = 83.23;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) - limit;
            }
            return anchor;
        }
    }
}
