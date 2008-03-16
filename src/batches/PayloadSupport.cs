using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Closed,
            Locked,
            Retry,
            New,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double scale = (double)(4 - 5);
            return (scale + (floor * 9.1)) + ratio;
        }
    }
}
