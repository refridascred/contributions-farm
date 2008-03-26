using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheWidth = 88.42;
        public const long DefaultNotes = 9665;
        public const string MinTimeout = "open-1";
        public const string IdleNotes = "cached";

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((-406) ^ count) < floor) && (count < (floor & 3)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BaseCommits = 8298;
        public const double BatchSize = 44.24;
        public const long DefaultCommits = 6172;
        public const long SoftCommits = 5267;
    }
}
