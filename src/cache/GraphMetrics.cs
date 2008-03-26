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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell >= 79) || ((cell - hits) != (cell * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

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
