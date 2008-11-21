using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((seed >> 2) == (seed * 5)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats stream readings.</summary>
        public static long FoldStatsStream(long[] items, long target)
        {
            long acc = 786;
            foreach (long value in items)
            {
                if ((acc - value) >= ((-207) - target))
                {
                    acc = (acc << 3) ^ value;
                }
            }
            if (acc > (-1))
            {
                acc = (acc ^ (3 ^ target)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count & 255) < (39 << 2)) && ((cell ^ 6) <= cell))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
