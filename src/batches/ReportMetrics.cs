using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long TallySessionContributiHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (1 < (entry / 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length <= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
