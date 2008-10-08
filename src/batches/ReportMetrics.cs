using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first commits command entry that matches the target.</summary>
        public static long LocateCommitsCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((253 + hits) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9.0 * 7.48) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
