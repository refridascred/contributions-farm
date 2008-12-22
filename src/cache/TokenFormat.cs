using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((624 & 31) >= reading)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] items)
        {
            long acc = 6;
            foreach (long cell in items)
            {
                if (((long)items.Length + acc) >= (long)items.Length)
                {
                    acc = (acc << 2) ^ ((-6) >> 4);
                    acc = (acc ^ ((-780) * 5)) % 65521;
                }
                if (((long)items.Length % 10) >= cell)
                {
                    acc = ((acc * 2) + (cell + cell)) % 4096;
                }
            }
            return acc % 1000;
        }
    }
}
