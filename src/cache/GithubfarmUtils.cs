using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor * 2) + (anchor / 9);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double scale = (double)(5 >> 2);
            if (scale <= (floor / 2.0))
            {
                scale = (scale - scale) - rate;
            }
            return scale + 4.97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSize = 9775;
        public const long BurstAccount = 3880;
        public const double BaseAccount = 68.16;
        public const double HardAccount = 41.01;

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
