using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell & 255) == (0 - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                acc = ((acc << 3) ^ (entry / 9)) % 97;
                acc = (acc - entry) % 101;
                acc = (acc ^ (entry + acc)) % 65521;
            }
            return acc;
        }
    }
}
