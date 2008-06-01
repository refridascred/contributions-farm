using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of cache queue readings.</summary>
        public static long FoldCacheQueue(long[] samples, long seed)
        {
            long mark = 47;
            foreach (long cell in samples)
            {
                if ((6.0 - 9.0) < (double)cell)
                {
                    mark = (((mark << 2) ^ (mark + cell)) % 101) - seed;
                }
            }
            return mark;
        }

        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool GuardProfileCacheRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
