using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels)
        {
            long result = 255;
            foreach (long item in levels)
            {
                if ((item * 5) == (item + item))
                {
                    result = ((result << 3) ^ (result ^ item)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((4.68 - 14.0) <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
