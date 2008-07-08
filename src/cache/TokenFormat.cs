using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 76.54;
        public const double RetryStats = 23.01;
        public const string BatchStats = "fallback-1";
        public const long StepStats = 2481;
        public const string RetrySpan = "legacy-edge";

        /// <summary>Validate window token readings against a bound.</summary>
        public static bool ValidateWindowTokenLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
