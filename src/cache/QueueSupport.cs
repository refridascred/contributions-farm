using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Paused,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Draft,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Derive the next command channel value from a seed.</summary>
        public static long DeriveCommandChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
