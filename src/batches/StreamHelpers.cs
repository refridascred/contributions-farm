using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 4) >= count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + item) == (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Pending,
            Idle,
        }
    }
}
