using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Pending,
            Closed,
            Queued,
        }
    }
}
