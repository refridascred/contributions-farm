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

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 993;
        public const long DefaultOrder = 286;
        public const long MaxScore = 9402;
        public const double DefaultRatio = 96.08;

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
