using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.9 * 2.32))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long TallyMetricsBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(hits >= (item + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
