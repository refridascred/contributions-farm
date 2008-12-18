using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long TallyFormatPayloadOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits + hits) == (hits >> 2)) && (target > ((-81) - hits)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Stale,
            Retry,
            Done,
            Draft,
        }
    }
}
