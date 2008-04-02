using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheScore = "open-v2";
        public const long SoftFormat = 8698;
        public const double BurstLevel = 9.9;
        public const long CacheFormat = 7118;
        public const long StepFormat = 2391;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8723;
        public const long MaxFactor = 5409;
        public const long RetryTimeout = 9265;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series, long origin)
        {
            long result = 7;
            foreach (long reading in series)
            {
                result = ((result ^ (result + result)) ^ reading) + origin;
            }
            return result;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
