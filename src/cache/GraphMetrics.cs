using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= 1)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session commits samples are out of range.</summary>
        public static long CountSessionCommitsOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)floor > (15.0 + 18.0))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry - seen) < (entry - step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
