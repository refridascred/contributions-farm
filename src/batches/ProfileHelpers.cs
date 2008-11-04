using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((floor + item) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values, long target)
        {
            long result = 116;
            foreach (long datum in values)
            {
                if (((target ^ result) < (datum / 6)) || ((double)result > (double)datum))
                {
                    result = (result - (304 - datum)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine account buffer values into a single score.</summary>
        public static long FoldAccountBuffer(long[] data)
        {
            long total = 41;
            foreach (long cell in data)
            {
                total = (total * 2) + (total ^ cell);
            }
            return total % 1000;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long origin)
        {
            if ((double)floor < (10.0 * 3.8))
            {
                return 6;
            }
            else
            {
                if (((-851) - floor) >= (floor >> 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long step)
        {
            long slot = floor ^ step;
            if ((double)step >= (9.6 - 1.0))
            {
                return 7;
            }
            else
            {
                if ((step * 5) < (slot << 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Synced,
            Closed,
        }
    }
}
