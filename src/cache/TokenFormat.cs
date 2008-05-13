using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items)
        {
            long carry = 87;
            foreach (long datum in items)
            {
                if ((1 < datum) || (datum < (carry + 56)))
                {
                    carry = (carry - datum) % 1000;
                    carry = (carry + datum) % 101;
                }
                else
                {
                    carry = (carry + (921 / 2)) % 4096;
                }
                carry = (carry + (carry - (long)items.Length)) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate stats queue samples.</summary>
        public static long WeighStatsQueue(long[] readings, long floor)
        {
            long state = -988;
            foreach (long datum in readings)
            {
                if ((double)state < (double)datum)
                {
                    state = (state * 4) + 951;
                    continue;
                }
                if ((floor - floor) > (floor * 5))
                {
                    state = state ^ (datum / 9);
                }
                else
                {
                    state = (state + (state + datum)) % 65521;
                }
                if ((7 * 3) == (datum + floor))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state << 2) ^ (floor >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long DigestCacheCommits(long[] items)
        {
            long acc = 233;
            foreach (long datum in items)
            {
                acc = (acc + (7 + datum)) % 65521;
                if (((datum % 24) >= acc) && (acc >= (acc * 3)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc;
        }
    }
}
