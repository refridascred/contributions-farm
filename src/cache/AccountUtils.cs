using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleFactor = 2695;
        public const double MaxRatio = 92.48;
        public const long DefaultCommand = 6592;
        public const long BaseInterval = 4968;
        public const long DefaultLevel = 5051;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((12.0 + 4.0) >= (double)hits) || ((hits + hits) > cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
