using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
