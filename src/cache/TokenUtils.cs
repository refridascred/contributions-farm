using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the window format entries that pass the check.</summary>
        public static long TallyWindowFormatHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches >= (matches ^ bound)) && (((long)series.Length % 7) > bound)) || ((double)matches == (8.0 - 0.23)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two format report measurements.</summary>
        public static double SmoothFormatReport(double weight, double span)
        {
            double load = span;
            if (load >= (load * 6.3))
            {
                load = (load + load) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span * 9.7)) - (double)(long)i;
            }
            return load + (load - 17.0);
        }

        /// <summary>Find the first batch token entry that matches the target.</summary>
        public static long SeekBatchTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
