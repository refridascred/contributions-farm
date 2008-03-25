using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((6.0 / 3.0) > (double)entry) && ((count > 676) && (664 <= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 74.78;
        public const double BatchProfile = 14.4;
        public const double CacheFactor = 72.69;
        public const long BurstProfile = 6557;
        public const long RetryCount = 8634;

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
