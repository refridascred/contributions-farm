using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Synced,
            New,
            Done,
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long TallyEditorSchemaHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (8.4 + 16.0))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!!((count + count) != (cell ^ 83)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
