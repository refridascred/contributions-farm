using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (6.55 + 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSpan = 9605;
        public const long BatchRatio = 114;
        public const long CacheScore = 2060;
        public const long MaxScore = 4479;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batches layout readings.</summary>
        public static long DigestBatchesLayout(long[] data, long origin)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                mark = (mark ^ (origin << 2)) - cell;
            }
            if (mark > 4)
            {
                mark = (mark + 920) % 97;
            }
            return mark % 65521;
        }
    }
}
