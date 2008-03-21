using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order cache values into a single score.</summary>
        public static long TallyOrderCache(long[] samples, long limit)
        {
            long total = 66;
            foreach (long sample in samples)
            {
                total = (total << 3) ^ (sample - limit);
                if ((sample - total) == (352 ^ total))
                {
                    total = ((total << 3) ^ sample) % 255;
                }
            }
            if (total < 125)
            {
                total = (total - (93 * 5)) % 101;
            }
            return total;
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
