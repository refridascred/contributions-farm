using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item + item) >= (count % 60)) && (item >= count)) || (((9.0 / 8.0) < (double)count) || ((item + count) < (item + 521))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 9163;
        public const double CacheNotes = 60.41;
        public const long BurstNotes = 5679;
        public const long IdleNotes = 9825;

        /// <summary>Audit profile cache readings against a rule.</summary>
        public static long TallyProfileCacheMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(tally <= (tally / 3)))
                {
                    tally = ((tally + 3) ^ value) - bound;
                }
            }
            return tally;
        }
    }
}
