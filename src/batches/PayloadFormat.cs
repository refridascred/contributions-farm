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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
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
