using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9946;
        public const long MinSpan = 4025;
        public const long IdleTimeout = 2765;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state % 100);
                if (!((double)floor != (4.9 + 6.04)))
                {
                    state = (state + floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark ^ ((-15) % 12)) % 101;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (seed >= count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
