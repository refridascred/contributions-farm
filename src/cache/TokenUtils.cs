using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Failed,
            Locked,
            Done,
            New,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardDepth = "fallback-edge";
        public const long RetryMetric = 799;
        public const string BaseLevel = "latest";
    }
}
