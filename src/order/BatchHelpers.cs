using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (20.0 < (double)hits)
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            Pending,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Iterate the filter farm series from a seed.</summary>
        public static long RollFilterFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((result >= floor) && ((result * 5) > (floor - 335)))
                {
                    result = result - (result + 727);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
