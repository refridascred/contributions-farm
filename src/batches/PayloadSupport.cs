using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long offset)
        {
            if ((double)offset < 8.6)
            {
                return 3;
            }
            else
            {
                if ((offset >> 5) > (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long TallyCacheBatchGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (1.62 / 2.0))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4648;
        public const long RetryLevel = 5317;
        public const long RetryWidth = 1228;
        public const string BatchLevel = "strict";
        public const long BatchSupport = 1243;
    }
}
