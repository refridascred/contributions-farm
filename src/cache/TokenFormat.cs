using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((36 ^ datum) < (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((floor << 2) >= tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
