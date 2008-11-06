using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((1.4 + 5.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (((0.96 / 8.0) >= (double)offset) || ((8.96 - 12.0) == (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Synced,
            Done,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
