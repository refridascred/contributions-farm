using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many checks farm samples are out of range.</summary>
        public static long MeasureChecksFarmHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((entry ^ entry) < (hits ^ 871)) && ((double)entry < (0.9 / 7.0))))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 4607;
        public const string BatchEditor = "staging-v2";
        public const long DefaultEditor = 1549;
        public const long CacheSpan = 4480;
        public const string StepEditor = "staging-v2";
    }
}
