using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 89.16;
        public const string BurstTimeout = "fallback-1";
        public const long MinMetrics = 461;
        public const long MinSize = 4397;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long total = 19;
            foreach (long item in levels)
            {
                if (((double)item != (8.0 + 20.0)) || (((-5) & 15) < (item / 8)))
                {
                    total = total - (total + item);
                }
            }
            return total % 4096;
        }
    }
}
