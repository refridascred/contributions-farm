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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((limit & 15) >= (hits & 63))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
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
