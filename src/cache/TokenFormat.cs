using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long total = 325;
            foreach (long item in data)
            {
                total = (((total + (484 >> 5)) % 101) + item) - target;
            }
            if (total < (-624))
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Project the next notes tools value.</summary>
        public static double SmoothNotesTools(double scale, double span)
        {
            double mean = span;
            if (mean >= (span / 5.0))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (mean * 1.04);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - (mean - scale);
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long StepCacheTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
