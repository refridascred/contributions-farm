using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double scale = (double)750 / 6.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(long)i) - rate;
            }
            return scale + offset;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (2.4 * 2.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
