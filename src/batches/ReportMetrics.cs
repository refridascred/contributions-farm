using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((6.6 - 3.0) > (double)step)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of stats command readings.</summary>
        public static long WeighStatsCommand(long[] samples, long floor)
        {
            long anchor = -645;
            foreach (long value in samples)
            {
                anchor = ((anchor << 2) ^ 9) + value;
            }
            if (anchor > 95)
            {
                anchor = anchor - (floor << 1);
            }
            return anchor % 97;
        }
    }
}
