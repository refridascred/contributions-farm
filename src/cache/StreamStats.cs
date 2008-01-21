using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long total = 38;
            foreach (long entry in levels)
            {
                total = ((total * 2) + (entry ^ total)) % 4096;
                if ((43 <= entry) || ((7.6 / 6.0) >= (double)total))
                {
                    total = (total ^ (entry & 1)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long seed)
        {
            long acc = 800;
            foreach (long item in data)
            {
                if (seed < (acc >> 4))
                {
                    acc = (acc + acc) - item;
                }
                if (7.46 >= (double)seed)
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
