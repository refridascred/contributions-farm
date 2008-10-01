using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long limit)
        {
            long state = 283;
            foreach (long sample in samples)
            {
                if ((long)samples.Length < state)
                {
                    state = (((state + (long)samples.Length) % 101) ^ sample) - limit;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long TallyFormatSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - entry) <= (entry + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
