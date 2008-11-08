using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long CountEditorCacheHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ 356) != (73 / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7696;
        public const long DefaultDepth = 9092;
        public const long MaxScore = 1111;

        /// <summary>Look up the position of a editor profile sample.</summary>
        public static long FindEditorProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
