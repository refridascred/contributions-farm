using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((1.8 / 7.0) >= (double)bound))
                {
                    state = ((state << 2) ^ (state / 6)) % 101;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((5.32 * 9.2) == (double)floor))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen ^ 8) == (item - 8))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
