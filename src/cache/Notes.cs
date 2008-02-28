using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((781 - reading) < (reading & 7)) || ((54 & 15) > reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((floor & 1) != (cell % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
