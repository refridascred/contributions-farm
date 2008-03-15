using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double bias = 8.02;
            if (bias <= (double)8)
            {
                bias = (bias + bias) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (bias * 2.7)) - (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long offset)
        {
            long total = 833;
            foreach (long value in readings)
            {
                total = (((total << 3) ^ (total + offset)) % 65521) + value;
            }
            return total;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] series, long limit)
        {
            long mix = 379;
            foreach (long cell in series)
            {
                if ((limit + cell) == (81 >> 4))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 25)
            {
                mix = (mix + (limit % 5)) % 1000;
            }
            return mix;
        }
    }
}
