using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell <= (bound >> 1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long TallyCacheEditorGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((long)values.Length & 127) < (item + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
