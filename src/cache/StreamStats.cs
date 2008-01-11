using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first batches filter entry that matches the target.</summary>
        public static long LocateBatchesFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepDepth = 4075;
        public const long BatchFormat = 9197;
        public const double MinFormat = 93.14;
        public const long SoftRatio = 2533;
        public const double HardFormat = 12.54;

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long step)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = ((acc - ((long)series.Length - 5)) ^ entry) + step;
            }
            if (acc > 94)
            {
                acc = (acc - (acc + 16)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
