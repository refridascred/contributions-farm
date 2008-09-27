using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardCount = 1066;
        public const long IdleLayout = 6413;
        public const string SoftLayout = "standard";
        public const string RetryLayout = "legacy-1";
        public const string SoftRatio = "strict";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
