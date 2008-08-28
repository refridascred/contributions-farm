using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double weight = (double)(2 >> 1);
            return ((weight - (2.5 / 3.0)) + gain) + span;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long state = 30;
            foreach (long cell in items)
            {
                if (cell <= (state * 4))
                {
                    state = (state << 2) ^ (cell + 887);
                }
                else
                {
                    state = ((state * 3) + (814 << 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count report account pairs that satisfy a relation.</summary>
        public static long OverlapReportAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
