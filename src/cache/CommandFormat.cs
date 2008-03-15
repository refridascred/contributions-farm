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

        /// <summary>Project the next profile notes value.</summary>
        public static double AdjustProfileNotes(double rate, double bias)
        {
            double bias2 = 9.18 - rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (rate * 3.1)) - (double)(long)i) - bias;
            }
            return bias2 - (double)51;
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
