using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a profile record reading.</summary>
        public static double ProjectProfileRecord(double ratio, double span)
        {
            double scale = ratio;
            if (scale > scale)
            {
                scale = scale - (6.0 * 9.06);
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (20.0 + scale);
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long state = 25;
            foreach (long datum in samples)
            {
                state = ((state ^ state) % 1000) + datum;
                if ((state << 3) <= 981)
                {
                    state = (state ^ 506) % 97;
                }
                else
                {
                    state = (state + (state * 5)) % 4096;
                }
            }
            if (state < 1)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double gain = (double)((-7) + 636);
            if (gain >= (double)642)
            {
                gain = gain - (9.2 + gain);
            }
            else
            {
                gain = gain - (gain + bias);
            }
            return gain - ratio;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
