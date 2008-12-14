using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 3894;
        public const string BurstCounter = "strict-edge";
        public const long CacheWidth = 4901;
        public const double MaxLevel = 75.96;
        public const string RetryCounter = "latest";

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics stats samples are out of range.</summary>
        public static long AuditMetricsStatsGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry % 100) == (matches + matches)) && (0.21 >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
