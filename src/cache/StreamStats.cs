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

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long SeriesToolsCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ acc) % 101;
                if ((acc >> 5) >= 2)
                {
                    acc = ((acc * 2) + acc) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!(result >= origin))
                {
                    result = (result * 2) + (result * 3);
                }
                result = ((result << 3) ^ ((-1) / 7)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
