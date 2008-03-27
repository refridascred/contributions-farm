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

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + matches) <= (2 << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 13.65;
        public const long WindowLayout = 9419;
        public const long SoftScore = 6364;
        public const double BaseLayout = 87.51;
        public const long LimitLayout = 9239;
    }
}
