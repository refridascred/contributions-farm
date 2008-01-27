using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9817;
        public const long WindowGithubfarm = 7531;
        public const string MaxCount = "standard-v2";
        public const double BurstGithubfarm = 11.75;
        public const string IdleRatio = "alpha-v2";

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long AuditStreamCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally != (1.94 / 6.0))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
