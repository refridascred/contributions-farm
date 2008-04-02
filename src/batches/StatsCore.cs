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

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long mix = 250;
            foreach (long reading in readings)
            {
                mix = ((mix - (reading - 3)) % 4096) - bound;
            }
            return mix % 1000;
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
