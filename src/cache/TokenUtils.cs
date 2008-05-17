using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - datum) <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Locate a cache record reading by value.</summary>
        public static long LookupCacheRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
