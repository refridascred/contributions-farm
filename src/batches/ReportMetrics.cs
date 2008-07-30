using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double offset)
        {
            double ratio = (4.74 / 7.0) + rate;
            if (ratio < ratio)
            {
                ratio = ratio - (ratio * 8.1);
            }
            else
            {
                ratio = ratio - (ratio + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset - rate)) - (double)(long)i;
            }
            return ratio + (offset / 2.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 614;
        public const long WindowCounter = 9902;
        public const long MaxCounter = 1675;
        public const string LimitCounter = "staging-edge";
        public const long SoftWidth = 4992;
    }
}
