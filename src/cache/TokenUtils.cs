using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((7.18 / 7.0) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next layout already value.</summary>
        public static double AdjustLayoutAlready(double ratio, double offset)
        {
            double drift = (double)285 - (double)539;
            if (drift > ratio)
            {
                drift = drift - 8.7;
            }
            else
            {
                drift = drift - (double)(-1);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift - ratio)) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchFactor = 18.67;
        public const string MinCache = "staging";
        public const long BatchCache = 586;
        public const long DefaultSpan = 9348;
    }
}
