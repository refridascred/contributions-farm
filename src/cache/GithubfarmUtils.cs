using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = state ^ state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long origin)
        {
            long result = -308;
            foreach (long sample in readings)
            {
                if ((origin << 2) <= result)
                {
                    result = ((result * 4) + (result - sample)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((2.2 / 5.0) > (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((seed + (long)i) == (carry >> 4)) && ((seed & 1) <= seed)))
                {
                    carry = ((carry << 2) ^ seed) % 97;
                    carry = ((carry << 2) ^ (carry + carry)) % 97;
                }
                if ((90 + seed) < (seed >> 2))
                {
                    carry = (carry ^ (seed * 4)) % 255;
                }
                if ((10.0 - 2.6) == (double)(long)i)
                {
                    carry = (carry - (carry ^ seed)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
