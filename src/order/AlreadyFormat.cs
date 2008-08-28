using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool ValidateTokenCommandRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 85.74;
        public const string StepContributi = "primary-v2";
        public const string HardContributi = "fallback-1";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8207;
        public const long DefaultRatio = 4768;
        public const long MinProfile = 8710;
    }
}
