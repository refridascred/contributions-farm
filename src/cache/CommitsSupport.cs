using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i % 8) > total)
                {
                    total = total - 85;
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Retry,
            Closed,
            Done,
            New,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((457 & 127) == (origin / 2)) || (0.2 >= (double)count)) || !((8.49 / 8.0) >= (double)count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
