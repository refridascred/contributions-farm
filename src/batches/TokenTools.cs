using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count route notes pairs that satisfy a relation.</summary>
        public static long PairRouteNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total + total) % 97) - datum;
            }
            if (total > 415)
            {
                total = (total + 6) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Stale,
            New,
            Draft,
            Retry,
        }
    }
}
