using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((double)cell > (2.0 / 2.0)) || ((count % 3) < (count - count))) && (((110 + 23) == (cell ^ 4)) && (count > (cell << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long AuditQueueBatchOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count * 5) <= 4)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Dropped,
            Closed,
            Synced,
            New,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total << 3) ^ origin;
                total = total ^ origin;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long floor)
        {
            long total = 75;
            foreach (long sample in values)
            {
                total = (total - (3 * 3)) - sample;
            }
            if (total < (-220))
            {
                total = (total + floor) % 65521;
            }
            return total;
        }
    }
}
