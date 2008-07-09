using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits ^ cell) == (cell - 310))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches / 2) <= 418)
                {
                    matches = ((matches + 2) + value) + target;
                }
            }
            return matches;
        }
    }
}
