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

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long WeighPayloadLayout(long[] readings, long offset)
        {
            long acc = 927;
            foreach (long cell in readings)
            {
                acc = ((acc ^ (cell + cell)) % 101) - offset;
                acc = acc + 9;
                acc = (acc ^ (acc & 31)) % 255;
            }
            return acc;
        }
    }
}
