using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((bound ^ hits) > bound)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster farm samples are out of range.</summary>
        public static long AuditClusterFarmMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum < (offset - tally)) && ((double)tally < (double)datum)) || ((datum & 63) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Pending,
            Ready,
            New,
        }
    }
}
