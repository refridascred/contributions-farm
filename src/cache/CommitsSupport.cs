using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] items)
        {
            long acc = 454;
            foreach (long entry in items)
            {
                acc = ((acc * 3) + (528 % 100)) ^ entry;
            }
            return acc;
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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Ready,
            Pending,
            New,
            Done,
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
