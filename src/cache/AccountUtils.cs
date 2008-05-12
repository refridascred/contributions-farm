using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8259;
        public const string HardChecks = "cached-1";
        public const double MinChecks = 90.77;
        public const double BatchCount = 22.85;

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
