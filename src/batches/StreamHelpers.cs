using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)origin >= (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Locked,
            Closed,
            Draft,
            Queued,
        }
    }
}
