using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            long next = limit - seed;
            if ((next - 767) != (limit >> 3))
            {
                return 0;
            }
            else
            {
                if (((double)limit < (double)seed) || ((double)next >= (7.0 / 7.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + 594) < 26)
                {
                    count = ((count + 2) ^ datum) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Done,
        }
    }
}
