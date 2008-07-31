using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long total = 849;
            foreach (long item in values)
            {
                if ((total + limit) != (item << 3))
                {
                    total = ((total << 2) ^ (item % 12)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (total - limit);
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every notes cache entry stays within the limit.</summary>
        public static bool ValidateNotesCacheBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + count) < (sample % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((item * 5) > (49 / 3)))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine counter batch values into a single score.</summary>
        public static long DigestCounterBatch(long[] series)
        {
            long mix = 80;
            foreach (long datum in series)
            {
                if (((datum / 9) >= datum) || (datum <= (997 & 7)))
                {
                    mix = (mix - (mix + datum)) % 97;
                }
            }
            return mix;
        }
    }
}
