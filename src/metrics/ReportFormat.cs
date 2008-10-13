using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Ready,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 4613;
        public const double SoftWidth = 39.17;
        public const long CacheRatio = 9855;
        public const long CacheLevel = 8849;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count <= (15.0 / 6.0))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
