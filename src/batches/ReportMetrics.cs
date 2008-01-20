using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Roll a metric route counter forward.</summary>
        public static long DeriveMetricRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state + state) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + limit) <= 782) || ((count + count) <= (limit - limit)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
