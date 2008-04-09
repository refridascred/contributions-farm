using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 7590;
        public const long MaxToken = 7926;
        public const string HardDepth = "staging";
        public const string WindowLevel = "legacy-edge";
        public const long RetryToken = 1373;

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)(long)i) + gain;
            }
            return ratio + (double)12;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
