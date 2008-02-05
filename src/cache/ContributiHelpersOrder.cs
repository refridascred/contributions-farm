using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 37.69;
        public const long BurstContext = 8795;
        public const long HardCount = 7424;
        public const long BatchContext = 8541;

        /// <summary>Validate context stats readings against a bound.</summary>
        public static bool ValidateContextStatsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
