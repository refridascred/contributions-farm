using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long total = 430;
            foreach (long entry in samples)
            {
                if ((limit >> 3) <= total)
                {
                    total = (total ^ (entry / 4)) % 4096;
                }
                else
                {
                    total = (total - total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Done,
            Queued,
            Idle,
        }
    }
}
