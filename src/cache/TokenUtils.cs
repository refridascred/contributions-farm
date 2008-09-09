using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (290 <= (reading + 44))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long bound, long bound2)
        {
            long next = bound - bound2;
            if ((double)bound2 > (double)bound)
            {
                return 3;
            }
            else
            {
                if (983 >= (bound >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 * 2.2) >= (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
