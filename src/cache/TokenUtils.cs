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

        /// <summary>Fold a list of order support readings.</summary>
        public static long CombineOrderSupport(long[] items, long floor)
        {
            long mix = 814;
            foreach (long reading in items)
            {
                if (773 > (mix - floor))
                {
                    mix = (mix - (reading + reading)) % 255;
                }
            }
            return mix;
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
