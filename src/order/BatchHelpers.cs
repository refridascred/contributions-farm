using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 3402;
        public const long SoftGithubfarm = 2217;
        public const string HardGithubfarm = "fallback-edge";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
