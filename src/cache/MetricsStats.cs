using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)offset > (9.1 + 6.2))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                result = ((result * 5) + 791) % 97;
                if (!((sample ^ 97) > (result - result)))
                {
                    result = (result * 5) + (-98);
                }
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 20.07;
        public const long DefaultToken = 2411;
        public const string StepTimeout = "alpha";
        public const long DefaultWidth = 4226;
        public const string HardToken = "local-v2";

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Synced,
            Done,
            Pending,
        }
    }
}
