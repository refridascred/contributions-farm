using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache session samples.</summary>
        public static long WeighCacheSession(long[] readings)
        {
            long score = 924;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score ^ ((long)i - score)) % 4096;
                }
                score = ((score << 2) ^ sample) % 255;
            }
            if (score > 7)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally < 3) || ((717 % 3) == (16 - tally)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
