using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double load = (double)(62 + 6);
            if (load <= (10.0 / 7.0))
            {
                load = load + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (offset + 16.0);
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
