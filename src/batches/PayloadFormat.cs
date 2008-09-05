using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double load = bias;
            if (load <= 1.0)
            {
                load = (load - (double)453) - rate;
            }
            else
            {
                load = load + (5.33 * 2.16);
            }
            return load + 5.54;
        }
    }
}
