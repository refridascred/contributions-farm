using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two window channel measurements.</summary>
        public static double SmoothWindowChannel(double ratio, double span)
        {
            double rate = ratio + ratio;
            if (rate > ratio)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(-58)) + (double)(long)i;
            }
            return rate + (double)644;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepSize = 4328;
        public const double SoftLevel = 35.56;
        public const long RetryRatio = 9308;
        public const double LimitScore = 31.86;
        public const long MinFactor = 8483;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}
