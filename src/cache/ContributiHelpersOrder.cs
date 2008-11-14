using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long offset)
        {
            long score = 0;
            foreach (long reading in series)
            {
                if (((9.5 * 4.1) >= (double)score) || ((offset % 3) == (reading << 1)))
                {
                    score = score ^ ((-91) % 97);
                }
                else
                {
                    score = score ^ 293;
                }
            }
            if (score < 4)
            {
                score = score + (score << 2);
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9753;
        public const long BatchAlready = 9938;
        public const double LimitTimeout = 96.59;
        public const long CacheAlready = 5195;

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > (ratio - scale))
            {
                scale = (scale - 7.0) - bias;
            }
            return scale + ratio;
        }
    }
}
