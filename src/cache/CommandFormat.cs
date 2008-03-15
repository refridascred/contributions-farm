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

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((2.0 - 11.0) <= (double)datum) && ((datum - seen) <= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
