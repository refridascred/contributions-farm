using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings, long step)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if (step > score)
                {
                    score = score ^ (cell & 7);
                }
            }
            return score % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < reading)
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
    }
}
