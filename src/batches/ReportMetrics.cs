using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((14.0 * 2.08) >= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((90 + offset) > (29 + origin)) && (origin >= 651))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen % 7) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
