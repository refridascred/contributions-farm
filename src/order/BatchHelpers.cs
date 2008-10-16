using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample < 3.0)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series, long step)
        {
            long anchor = 72;
            foreach (long entry in series)
            {
                anchor = anchor + (entry - anchor);
                if ((entry - 55) < (entry ^ entry))
                {
                    anchor = anchor - step;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 5) + (anchor & 31)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next stats profile value from a seed.</summary>
        public static long DeriveStatsProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ 0;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
