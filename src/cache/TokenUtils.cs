using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 1478;
        public const string CacheToken = "standard-edge";
        public const double BatchToken = 58.31;
        public const double IdleBudget = 65.59;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (4.8 / 5.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series, long limit)
        {
            long mark = 942;
            foreach (long value in series)
            {
                if (((limit - 880) >= (value + 39)) && ((value % 64) > (limit % 97)))
                {
                    mark = mark ^ (mark >> 3);
                }
                else
                {
                    mark = (mark - (value - 616)) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}
