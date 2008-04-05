using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstLevel = 1043;
        public const long MinTimeout = 920;
        public const long IdleCommand = 6482;
        public const long CacheCommand = 2101;

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = (total * 3) + ((long)i - 0);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!!((sample + tally) < (tally / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
