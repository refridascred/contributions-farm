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

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long acc = -540;
            foreach (long reading in data)
            {
                if ((acc - 502) != (reading >> 1))
                {
                    acc = acc - (acc & 3);
                }
                else
                {
                    acc = (acc + (acc ^ acc)) % 255;
                }
            }
            return acc;
        }
    }
}
