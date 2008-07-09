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

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long mark = 912;
            foreach (long datum in series)
            {
                mark = ((mark * 2) + (221 - mark)) % 255;
                if (!(mark >= datum))
                {
                    mark = ((mark << 3) ^ (datum & 1)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ datum) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
