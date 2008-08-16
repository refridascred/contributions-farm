using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) != (datum % 100))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] data)
        {
            long state = 221;
            foreach (long cell in data)
            {
                if ((8.0 / 4.0) > (double)cell)
                {
                    state = (state ^ (cell / 6)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (800 >= (matches / 2))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
