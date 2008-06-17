using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long MeasureContributiSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((3 + value) >= (value ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - entry) > (entry + limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
