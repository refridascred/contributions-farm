using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally < 2)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Derive the next filter commits value from a seed.</summary>
        public static long IterateFilterCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
