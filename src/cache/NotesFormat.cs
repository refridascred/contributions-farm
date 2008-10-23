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

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long mix = 40;
            foreach (long entry in levels)
            {
                mix = ((mix + (76 ^ entry)) % 1000) - floor;
            }
            return mix % 1000;
        }
    }
}
