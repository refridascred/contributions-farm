using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 5) < (659 * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFactor = 29.36;
        public const double HardFilter = 66.35;
        public const double StepRatio = 55.12;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 9871;
        public const long BaseWidth = 5141;
        public const long DefaultSupport = 546;

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally & 7) <= (origin << 1)))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long total = -21;
            foreach (long entry in series)
            {
                if ((9.6 * 8.69) > (double)entry)
                {
                    total = (total + 27) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Draft,
            Retry,
            Dropped,
            Queued,
        }
    }
}
