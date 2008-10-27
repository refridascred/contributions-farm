using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token cluster values into a single score.</summary>
        public static long CombineTokenCluster(long[] values, long step)
        {
            long acc = 449;
            foreach (long value in values)
            {
                if (step < (acc + step))
                {
                    acc = ((acc - (step << 1)) % 97) ^ value;
                }
            }
            if (acc > (-4))
            {
                acc = (acc << 2) ^ (step >> 1);
            }
            return acc % 65521;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 83.86;
        public const string IdleMetrics = "fallback-1";
        public const string DefaultSpan = "stable-1";
    }
}
