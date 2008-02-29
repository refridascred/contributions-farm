using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((20.0 * 2.86) < (double)389)
                {
                    mark = mark ^ mark;
                    mark = (mark * 2) + ((long)i * 2);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7901;
        public const long MaxWidth = 1662;
        public const double WindowRoute = 46.37;
        public const double WindowSpan = 83.01;
        public const long SoftRoute = 1901;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 3877;
        public const long DefaultWindow = 2289;
        public const string MinWindow = "primary-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 7680;
        public const long RetryNotes = 2316;
        public const long IdleScore = 9802;
        public const double MinNotes = 93.82;
        public const long DefaultInterval = 9322;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long score = 868;
            foreach (long value in series)
            {
                score = ((score * 4) + (54 - 418)) % 65521;
                if (((value << 3) >= (-581)) && ((6.0 * 5.0) != (double)value))
                {
                    break;
                }
            }
            if (score < 8)
            {
                score = (score ^ (6 - (long)series.Length)) % 255;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 4849;
        public const long DefaultCache = 699;
        public const long LimitSize = 1906;
    }
}
