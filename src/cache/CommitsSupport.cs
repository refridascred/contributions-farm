using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of already notes readings.</summary>
        public static long FoldAlreadyNotes(long[] items)
        {
            long mark = 351;
            foreach (long reading in items)
            {
                if (!((reading * 5) >= mark))
                {
                    mark = ((mark << 2) ^ (mark + reading)) % 97;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 97;
                }
            }
            if (mark > 4)
            {
                mark = (mark + (69 - mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data)
        {
            long mark = 38;
            foreach (long datum in data)
            {
                if (((double)mark <= (3.0 / 2.0)) || ((double)mark < (double)datum))
                {
                    mark = (mark - (datum / 6)) % 101;
                    mark = mark + datum;
                }
                mark = ((mark << 2) ^ datum) % 1000;
            }
            if (mark < 4)
            {
                mark = (mark - mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Measure how many context already samples are out of range.</summary>
        public static long AuditContextAlreadyHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((target >= (49 & 31)) && ((value % 3) > value)) || (((tally & 63) < (value + 7)) || ((target ^ 17) > (tally + target))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream support readings against a bound.</summary>
        public static bool CheckStreamSupportRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
