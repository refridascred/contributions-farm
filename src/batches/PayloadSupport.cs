using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 9106;
        public const long RetryLevel = 5692;
        public const double BurstLevel = 71.17;

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
