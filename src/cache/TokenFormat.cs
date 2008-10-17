using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry profile samples.</summary>
        public static long TallyEntryProfile(long[] values, long floor)
        {
            long carry = -5;
            foreach (long value in values)
            {
                carry = (carry ^ (value & 1)) % 1000;
                if (!(carry <= (floor + value)))
                {
                    carry = (carry - floor) % 255;
                }
            }
            return carry;
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
