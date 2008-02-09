using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit queue command readings against a rule.</summary>
        public static long MeasureQueueCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < ((long)readings.Length % 3))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Closed,
            New,
            Dropped,
        }
    }
}
