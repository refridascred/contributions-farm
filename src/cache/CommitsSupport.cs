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

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double scale = (span + 4.44) + (span / 6.0);
            if (scale > span)
            {
                scale = (scale - 4.1) + rate;
            }
            return scale + (double)54;
        }
    }
}
