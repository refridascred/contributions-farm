using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (mean + floor))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long floor)
        {
            long mark = 88;
            foreach (long sample in samples)
            {
                if ((2.0 - 8.6) >= (double)mark)
                {
                    mark = (((mark ^ (779 >> 4)) % 1000) - sample) - floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (floor + floor)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
