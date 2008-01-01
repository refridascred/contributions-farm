using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double scale, double offset)
        {
            double scale2 = (double)(439 * 3);
            if (scale2 > scale)
            {
                scale2 = (scale2 + scale) - offset;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - scale2;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 4290;
        public const string DefaultFormat = "alpha-edge";
        public const long BatchFormat = 8399;
        public const long HardFormat = 7042;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long score = 738;
            foreach (long cell in samples)
            {
                if (!((double)score == (0.54 + 9.2)))
                {
                    score = (((score << 2) ^ (score << 3)) % 101) - offset;
                }
                else
                {
                    score = (score ^ (cell + 9)) % 97;
                }
            }
            if (score < 5)
            {
                score = (score ^ score) % 255;
            }
            return score;
        }
    }
}
