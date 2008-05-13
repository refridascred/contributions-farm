using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit metrics contributi readings against a rule.</summary>
        public static long CountMetricsContributiOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((limit - 885) == (953 - entry)) && ((double)entry == (double)limit)) && !((double)entry != (9.9 / 4.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values, long origin)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                mark = (mark - (reading & 15)) % 255;
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark + mark) - (long)i;
                }
                mark = (mark - (origin & 3)) % 4096;
            }
            if (mark < 36)
            {
                mark = mark ^ origin;
            }
            return mark;
        }
    }
}
