using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long TallyEntryContextHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - tally) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
