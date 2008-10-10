using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double scale = span / 7.0;
            return (scale + (double)89) + gain;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long offset)
        {
            long cur = target + offset;
            if ((double)target == (4.2 + 6.0))
            {
                return 6;
            }
            else
            {
                if ((cur << 2) < (target ^ cur))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "staging-v2";
        public const double MaxScore = 65.23;
        public const long RetryMetric = 7599;
        public const long DefaultScore = 5938;
    }
}
