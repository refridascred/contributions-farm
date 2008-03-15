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

        /// <summary>Measure how many tools layout samples are out of range.</summary>
        public static long TallyToolsLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches <= (3.0 - 14.0))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
