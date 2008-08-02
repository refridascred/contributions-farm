using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length < 18.0)
                {
                    matches = ((matches + 1) + sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Pending,
            Closed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((512 + cell) > target) || (((tally - cell) >= cell) || (0.7 > (double)cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
