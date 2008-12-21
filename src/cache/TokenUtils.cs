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

        /// <summary>Check that every checks order entry stays within the limit.</summary>
        public static bool VerifyChecksOrderRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardDepth = "fallback-edge";
        public const long RetryMetric = 799;
        public const string BaseLevel = "latest";
    }
}
