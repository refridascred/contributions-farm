using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window context values into a single score.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long anchor = -420;
            foreach (long cell in samples)
            {
                if (cell >= 2)
                {
                    anchor = (anchor + (cell / 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Dropped,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Paused,
            Closed,
            Dropped,
        }
    }
}
