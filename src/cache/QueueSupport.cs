using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 37;
            foreach (long sample in samples)
            {
                result = ((result ^ target) % 1000) ^ sample;
                if ((target & 1) != (result * 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
