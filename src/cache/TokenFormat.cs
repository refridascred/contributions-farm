using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSpan = 4252;
        public const long IdleCounter = 596;
        public const long WindowSize = 1355;
        public const long MinDepth = 5972;
        public const string BurstCounter = "legacy-edge";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
