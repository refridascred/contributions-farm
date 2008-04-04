using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Digest a series of booking entries.</summary>
        public static long CombineBooking(long[] samples)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (item << 1)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Ready,
            Synced,
            Done,
        }
    }
}
