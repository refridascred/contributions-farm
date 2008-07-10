using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + sample) >= (sample % 16))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            New,
            Stale,
        }
    }
}
