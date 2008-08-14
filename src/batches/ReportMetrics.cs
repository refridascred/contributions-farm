using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >> 4) > (datum >> 3))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 3) > item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
