using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cache batches entries that pass the check.</summary>
        public static long CountCacheBatchesHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((double)floor == (double)reading) && ((36 % 64) > (3 ^ floor))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits < (5.7 * 9.6))
                {
                    hits = ((hits + 2) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Rank window metric input into a small class.</summary>
        public static long ClassifyWindowMetric(long limit, long origin)
        {
            if ((origin + 234) > 4)
            {
                return 4;
            }
            else
            {
                if ((limit * 5) >= (origin + limit))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((6.5 + 7.99) < (double)(long)levels.Length))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
