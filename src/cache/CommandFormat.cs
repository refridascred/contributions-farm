using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Queued,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double rate = (offset / 4.0) + (bias / 3.0);
            if (rate > (offset - 1.92))
            {
                rate = rate - (offset + rate);
            }
            return rate - (bias / 2.0);
        }
    }
}
