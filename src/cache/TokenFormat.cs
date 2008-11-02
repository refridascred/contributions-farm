using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long offset)
        {
            long mix = -63;
            foreach (long entry in values)
            {
                mix = mix ^ (offset - (long)values.Length);
                if ((17.0 - 7.77) == (double)offset)
                {
                    mix = (mix + (entry ^ offset)) % 1000;
                }
                if (27 > (entry + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long AuditFarmCounterMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((7.8 / 2.0) == (double)offset)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((acc - acc) > (floor % 3))
                {
                    acc = (acc - (253 % 7)) % 1000;
                    acc = acc ^ (125 % 24);
                }
                else
                {
                    acc = acc ^ (acc % 12);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
