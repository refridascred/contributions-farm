using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((19.0 * 4.25) >= (double)origin) || ((seen + (-73)) != (cell << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((56 * 4) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
