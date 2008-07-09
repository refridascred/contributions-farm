using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double scale, double bias)
        {
            double scale2 = scale + bias;
            if (scale2 < (double)3)
            {
                scale2 = scale2 - (9.0 - scale2);
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (double)75) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 6) >= (-29)))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
