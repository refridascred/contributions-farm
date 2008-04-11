using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((state * 2) <= (long)i)
                {
                    state = ((state << 3) ^ origin) % 97;
                    continue;
                }
                else
                {
                    state = state ^ (state - origin);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry ^ (long)series.Length) + entry;
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
