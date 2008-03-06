using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ limit;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
