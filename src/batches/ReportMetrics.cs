using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitWidth = 7074;
        public const string DefaultAlready = "strict-edge";
        public const string WindowAlready = "legacy-v2";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double gain2 = (double)46;
            if (gain2 < (floor - floor))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (7.8 * 8.0);
            }
            return gain2 + gain2;
        }
    }
}
