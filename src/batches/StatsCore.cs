using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools channel samples are out of range.</summary>
        public static long AuditToolsChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((590 * 5) > seen)
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(830 <= (hits + item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 9110;
        public const double RetrySpan = 48.2;
        public const long BurstGithubfarm = 4931;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 23.6;
        public const string BurstFactor = "legacy";
        public const long DefaultEntry = 6524;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitRatio = 4921;
        public const long BaseCount = 6704;
        public const string LimitToken = "open-1";
        public const long SoftToken = 7532;
        public const long HardToken = 9318;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
