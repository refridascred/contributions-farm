using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4441;
        public const string StepFactor = "fallback-v2";
        public const long CacheRatio = 1544;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long DigestEntryBatch(long[] levels, long limit)
        {
            long sum = 11;
            foreach (long sample in levels)
            {
                if ((3 & 31) < (sum % 3))
                {
                    sum = ((sum ^ sample) % 4096) - limit;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double rate = bias;
            return rate + scale;
        }
    }
}
