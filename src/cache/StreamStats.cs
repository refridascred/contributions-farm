using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine payload channel values into a single score.</summary>
        public static long DigestPayloadChannel(long[] series)
        {
            long state = 65;
            foreach (long cell in series)
            {
                if ((state >= (state >> 2)) || ((cell * 5) < cell))
                {
                    state = (state ^ (state + cell)) % 255;
                    break;
                }
                state = ((state << 3) ^ (cell & 255)) % 255;
                if (!((state - cell) != (state ^ 592)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a account schema counter forward.</summary>
        public static long SeriesAccountSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ step;
                carry = (carry << 3) ^ ((-1) ^ step);
                carry = ((carry << 3) ^ step) % 4096;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
