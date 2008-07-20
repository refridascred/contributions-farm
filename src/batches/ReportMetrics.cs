using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark - (84 + 706)) - (long)i2;
                }
                mark = (mark * 4) + bound;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Done,
            Locked,
            Ready,
        }
    }
}
