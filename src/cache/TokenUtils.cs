using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item * 2) != (6 + bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > (entry + limit))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
