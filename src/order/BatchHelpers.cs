using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double load = (double)(89 & 1);
            return ((load - (double)77) + ratio) + bias;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
