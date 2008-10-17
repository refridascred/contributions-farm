using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] levels, long offset)
        {
            long result = 36;
            foreach (long reading in levels)
            {
                if ((result - offset) < 589)
                {
                    result = result - (reading >> 5);
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((0 % 5) != (floor >> 2)) && ((double)mix >= 11.0))
                {
                    mix = (mix << 2) ^ (mix + mix);
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (6.6 > (double)target)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
