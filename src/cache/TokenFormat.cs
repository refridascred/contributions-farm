using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 2) ^ (27 ^ anchor)) - sample;
            }
            if (anchor < 8)
            {
                anchor = anchor - (anchor & 1);
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 3488;
        public const long BaseDepth = 3470;
        public const double SoftMetrics = 48.96;
        public const string MaxScore = "fallback-v2";
    }
}
