using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8964;
        public const double BatchLevel = 9.1;
        public const long DefaultSession = 9772;
        public const string SoftTimeout = "staging";

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double floor)
        {
            double gain2 = (double)(3 & 63);
            return (gain2 + (gain2 + gain)) + floor;
        }
    }
}
