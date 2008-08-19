using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((seed2 & 3) <= (seed ^ seed2))
            {
                return 0;
            }
            else
            {
                if ((seed2 & 127) < (delta + seed))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                anchor = ((anchor + (step ^ anchor)) % 1000) + item;
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= ((-42) << 2))
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
