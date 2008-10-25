using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            New,
            Queued,
            Done,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                if ((double)carry != (8.4 - 9.8))
                {
                    carry = ((carry ^ carry) % 255) ^ entry;
                }
                if (carry < (233 % 7))
                {
                    carry = (carry * 2) + (-911);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 83;
            foreach (long datum in series)
            {
                acc = ((acc * 3) + acc) % 65521;
                if (datum <= ((-6) >> 1))
                {
                    acc = (acc - (datum + acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc % 7)) % 97;
                }
            }
            if (acc > 26)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Count payload contributi pairs that satisfy a relation.</summary>
        public static long PairPayloadContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
