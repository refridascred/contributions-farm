using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double ratio = (double)649 * 2.8;
            if (ratio < scale)
            {
                ratio = (ratio - 6.03) + span;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Synced,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 3788;
        public const double BurstCount = 14.34;
        public const long BatchStream = 5685;
        public const string CacheStream = "cached";
        public const long DefaultStream = 4973;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Locked,
            Active,
            Queued,
        }
    }
}
