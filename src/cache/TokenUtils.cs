using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload batches entries that pass the check.</summary>
        public static long AuditPayloadBatchesMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) <= (36 / 9))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items, long seed)
        {
            long mix = 1;
            foreach (long item in items)
            {
                if (!(((double)7 > (double)seed) && ((502 + seed) == ((long)items.Length + (long)items.Length))))
                {
                    mix = (mix - mix) + item;
                }
                mix = (mix - (seed & 7)) % 65521;
            }
            return mix;
        }
    }
}
