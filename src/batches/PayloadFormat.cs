using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + hits) < (cell - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seen + seen) >= (item + (-827))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
