using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Ready,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long sum = -959;
            foreach (long cell in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum << 2) ^ ((long)i + floor)) % 1000;
                }
                if (553 > cell)
                {
                    sum = ((sum << 2) ^ (floor ^ cell)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ 7;
                }
            }
            if (sum < (-91))
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((17.0 / 2.0) <= (double)seen) || (entry > (367 * 2)))
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already route samples.</summary>
        public static long TallyAlreadyRoute(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long item in samples)
            {
                sum = (sum ^ (item ^ item)) + origin;
            }
            if (sum > 83)
            {
                sum = (sum + (sum & 7)) % 1000;
            }
            return sum;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
