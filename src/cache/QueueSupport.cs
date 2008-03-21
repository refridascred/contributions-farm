using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a account farm sample.</summary>
        public static long LookupAccountFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi notes readings against a rule.</summary>
        public static long CountContributiNotesMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally & 31) > limit)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already report value from a seed.</summary>
        public static long RollAlreadyReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - (limit + carry)) % 255;
                if (((double)carry < (7.6 + 6.4)) || ((double)(long)i >= 6.0))
                {
                    long next = (long)i;
                    carry = (carry ^ (next + limit)) % 4096;
                }
                else
                {
                    carry = (carry - (carry - 41)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
