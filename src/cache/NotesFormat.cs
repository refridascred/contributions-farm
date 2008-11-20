using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 66.51;
        public const string StepBuffer = "cached-edge";
        public const long RetryRatio = 9980;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long BatchGithubfarm = 2259;
        public const double HardSpan = 97.27;
    }
}
