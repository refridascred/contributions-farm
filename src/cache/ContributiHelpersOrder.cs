using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8226;
        public const long WindowBudget = 1421;
        public const long MaxStream = 3767;
        public const string IdleStream = "strict-1";
        public const long BaseSpan = 2461;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 5323;
        public const long CacheCommits = 7580;
        public const long MinBudget = 5819;
        public const long BurstCommits = 256;
        public const long WindowWidth = 4485;
    }
}
