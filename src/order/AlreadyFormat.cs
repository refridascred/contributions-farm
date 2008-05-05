using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinFactor = 654;
        public const long SoftTimeout = 4357;
        public const string BatchWidth = "strict-1";
        public const long BurstInterval = 725;

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 30.05;
        public const long StepRecord = 7058;
        public const long HardLevel = 6978;
        public const long DefaultRecord = 6931;
        public const string IdleBudget = "fallback-edge";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (43 << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
