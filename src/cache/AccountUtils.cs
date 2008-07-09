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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
