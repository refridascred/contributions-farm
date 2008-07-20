using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Locked,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Closed,
            Active,
            Done,
            Retry,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            New,
            Failed,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 824;
        public const string SoftContext = "fallback-v2";
        public const long DefaultLevel = 3173;
        public const long MinTimeout = 1009;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleFactor = 1673;
        public const string MaxDepth = "fallback";
        public const long MaxBudget = 5629;
        public const double SoftRecord = 23.43;
    }
}
