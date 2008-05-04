using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
