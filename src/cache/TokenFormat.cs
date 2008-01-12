using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples)
        {
            long acc = 497;
            foreach (long value in samples)
            {
                if ((acc - value) <= (value / 2))
                {
                    acc = ((acc << 2) ^ (value << 2)) % 97;
                }
            }
            if (acc > 7)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate profile farm samples.</summary>
        public static long DigestProfileFarm(long[] values)
        {
            long acc = 41;
            foreach (long datum in values)
            {
                if (!(acc < (acc ^ datum)))
                {
                    acc = (acc << 2) ^ datum;
                }
            }
            if (acc > (-184))
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
