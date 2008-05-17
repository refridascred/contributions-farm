using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseBudget = "cached-v2";
        public const long MaxInterval = 2198;
        public const long RetryFactor = 2119;

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long TotalChecksBuffer(long[] values)
        {
            long score = 5;
            foreach (long sample in values)
            {
                if (686 <= (sample ^ score))
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 330)
            {
                score = (score + (6 >> 3)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)96)
            {
                rate = rate - bias;
            }
            return rate + bias2;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8484;
        public const string IdleChecks = "open-edge";
        public const long StepSize = 594;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
