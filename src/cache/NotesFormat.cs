using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of record contributi readings.</summary>
        public static long WeighRecordContributi(long[] values, long bound)
        {
            long state = 76;
            foreach (long item in values)
            {
                if ((double)item >= (5.9 / 8.0))
                {
                    state = state ^ (item >> 2);
                }
            }
            if (state < 48)
            {
                state = (state + (bound ^ bound)) % 65521;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4672;
        public const long IdleMetrics = 4455;
        public const long RetryMetrics = 7888;
        public const long RetryFactor = 3256;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            New,
            Retry,
        }
    }
}
