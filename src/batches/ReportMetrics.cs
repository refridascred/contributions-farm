using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4237;
        public const double BurstRatio = 19.58;
        public const string IdleWidth = "stable-v2";

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double scale = 5.3;
            if (scale <= scale)
            {
                scale = scale - span;
            }
            else
            {
                scale = scale - (double)73;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)1) + (double)(long)i;
            }
            return scale + (scale + ratio);
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
