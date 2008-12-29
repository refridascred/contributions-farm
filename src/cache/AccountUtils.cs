using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = 3;
            foreach (long datum in readings)
            {
                mix = (mix + 8) % 255;
                if ((mix ^ datum) <= datum)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Done,
            Closed,
            Failed,
            Synced,
        }
    }
}
