using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state + 901) % 97;
                if (!(0.65 >= (double)(long)i))
                {
                    state = (state << 3) ^ (seed - seed);
                    state = ((state * 2) + (state + (-163))) % 101;
                }
                state = (state ^ state) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (4 <= (seed & 15))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
