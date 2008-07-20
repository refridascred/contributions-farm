using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "latest-edge";
        public const long MinBudget = 9124;
        public const long WindowWidth = 6453;
        public const long BurstCommits = 2769;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
