using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double mean = (1.0 + floor) - (floor / 3.0);
            return (mean - 6.26) + scale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 3368;
        public const string DefaultSpan = "alpha-v2";
        public const double WindowChecks = 10.01;
        public const double CacheChecks = 48.03;
        public const long CacheSpan = 7691;

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long score = 62;
            foreach (long datum in values)
            {
                score = score - (9 ^ score);
                if ((datum < score) && ((94 + score) >= (score << 1)))
                {
                    score = score ^ ((-2) / 4);
                }
            }
            return score;
        }
    }
}
