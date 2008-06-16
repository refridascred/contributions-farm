using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((471 & 15) < hits)
                {
                    hits = ((hits + 1) + entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Locate a token counter reading by value.</summary>
        public static long FindTokenCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
