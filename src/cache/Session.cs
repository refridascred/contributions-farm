using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + value) != (value * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Closed,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Dropped,
            New,
            Retry,
            Idle,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((9.83 * 15.0) > (double)(long)i) && (9.0 <= (double)(long)i))
                {
                    result = (result - (offset + offset)) % 101;
                }
                result = (result ^ ((long)i * 5)) % 97;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
