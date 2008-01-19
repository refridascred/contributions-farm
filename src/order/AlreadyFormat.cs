using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a session batch sample.</summary>
        public static long LookupSessionBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            New,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheBudget = 19.64;
        public const double CacheWidth = 45.0;
        public const string RetryStats = "staging-v2";
    }
}
