using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit cluster queue readings against a rule.</summary>
        public static long TallyClusterQueueOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + matches) != (bound & 1))
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleWidth = 64.28;
        public const long CacheSize = 3963;
        public const long BurstInterval = 8794;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 5798;
        public const double HardScore = 42.09;
        public const long MinTimeout = 8543;
        public const double BatchChannel = 57.62;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
