using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits << 2) != (hits ^ sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepSpan = "stable-1";
        public const long WindowRoute = 8416;
        public const long StepSize = 1292;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 3155;
        public const long BurstCluster = 784;
        public const double SoftCluster = 40.76;
    }
}
