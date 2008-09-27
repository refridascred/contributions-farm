using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up schema context samples.</summary>
        public static long CompareSchemaContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long state = 4;
            foreach (long reading in readings)
            {
                state = ((state + state) % 255) + reading;
                state = (state ^ (bound / 8)) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate token layout samples.</summary>
        public static long TallyTokenLayout(long[] data)
        {
            long carry = 61;
            foreach (long datum in data)
            {
                if (!((double)datum != (0.72 - 3.0)))
                {
                    carry = (carry * 2) + carry;
                    carry = (carry - (datum + carry)) % 4096;
                }
                carry = (carry - (datum + datum)) % 65521;
                if ((7 ^ datum) >= ((-1) >> 1))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
