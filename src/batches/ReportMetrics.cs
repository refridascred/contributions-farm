using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
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
