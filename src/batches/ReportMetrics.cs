using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
