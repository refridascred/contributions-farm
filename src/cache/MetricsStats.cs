using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series, long seed)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                if ((1.87 + 5.0) != (double)seed)
                {
                    mix = (mix + (mix >> 2)) - entry;
                }
                else
                {
                    mix = (mix + (13 - seed)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Ready,
            Paused,
            Closed,
            Pending,
        }
    }
}
