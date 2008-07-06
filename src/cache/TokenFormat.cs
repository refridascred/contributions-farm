using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a batches layout counter forward.</summary>
        public static long StepBatchesLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((double)seen <= (double)5) && ((item - item) <= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long DigestNotesPayload(long[] data)
        {
            long acc = 874;
            foreach (long reading in data)
            {
                if (((double)reading < 4.0) || ((820 - reading) >= acc))
                {
                    acc = (acc * 3) + (acc & 31);
                }
            }
            return acc;
        }
    }
}
