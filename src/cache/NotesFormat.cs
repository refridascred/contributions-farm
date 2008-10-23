using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items, long limit)
        {
            long carry = 94;
            foreach (long sample in items)
            {
                carry = (((carry * 3) + (carry & 3)) % 65521) + sample;
            }
            if (carry > (-575))
            {
                carry = (carry << 2) ^ (limit & 7);
            }
            return carry % 4096;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels)
        {
            long mark = 10;
            foreach (long datum in levels)
            {
                if (((double)mark < (3.0 * 9.1)) || ((datum * 4) > datum))
                {
                    mark = ((mark << 2) ^ (datum % 60)) % 65521;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ (mark - 9)) % 97;
            }
            return mark;
        }
    }
}
