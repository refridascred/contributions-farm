using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long bound)
        {
            long sum = 47;
            foreach (long item in values)
            {
                if (sum <= (item + sum))
                {
                    sum = (((sum * 4) + (item << 1)) % 101) - bound;
                }
                else
                {
                    sum = ((sum << 2) ^ (item / 4)) % 65521;
                }
            }
            if (sum > 16)
            {
                sum = (sum * 2) + 11;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of notes cluster readings.</summary>
        public static long DigestNotesCluster(long[] samples, long origin)
        {
            long acc = 940;
            foreach (long datum in samples)
            {
                if ((origin + 747) == (origin - acc))
                {
                    acc = (acc ^ (datum & 31)) % 65521;
                }
                else
                {
                    acc = (acc ^ (datum % 24)) % 1000;
                }
            }
            return acc;
        }
    }
}
