using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Combine window commits values into a single score.</summary>
        public static long TallyWindowCommits(long[] series)
        {
            long anchor = -42;
            foreach (long sample in series)
            {
                anchor = (((anchor << 2) ^ (anchor + 6)) % 4096) + sample;
                anchor = ((anchor << 2) ^ (459 - (long)series.Length)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Closed,
            Draft,
            Stale,
            New,
        }
    }
}
