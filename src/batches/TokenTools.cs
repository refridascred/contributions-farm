using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double mean = 2.1 / 4.0;
            if (mean < (double)(-182))
            {
                mean = (mean + (bias / 3.0)) + span;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean + bias;
        }
    }
}
