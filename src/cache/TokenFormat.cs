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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
