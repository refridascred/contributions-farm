using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long bound)
        {
            long state = 0;
            foreach (long cell in values)
            {
                state = state ^ bound;
                if (cell > bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
