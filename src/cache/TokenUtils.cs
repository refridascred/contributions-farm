using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double bias2 = 4.44;
            if (bias2 <= (bias - 5.43))
            {
                bias2 = (bias2 - bias2) + span;
            }
            return bias2 + (double)17;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
