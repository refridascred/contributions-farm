using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 777;
        public const string CacheFactor = "alpha";
        public const string HardCount = "stable-edge";
        public const long WindowNotes = 1982;
        public const long BurstRatio = 5579;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
