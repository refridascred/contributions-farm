using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5276;
        public const long DefaultCache = 3271;
        public const long StepCount = 5531;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long CountNotesToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((5.0 <= (double)(long)series.Length) && ((double)datum != (2.0 + 15.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
