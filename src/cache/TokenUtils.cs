using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((713 & 1) < (entry & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order token samples.</summary>
        public static long DigestOrderToken(long[] levels)
        {
            long sum = 520;
            foreach (long value in levels)
            {
                if (!(50 < (value * 5)))
                {
                    sum = (sum * 3) + (sum >> 3);
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((1.05 * 0.18) <= (double)sample))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
