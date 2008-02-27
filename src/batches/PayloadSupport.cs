using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double weight = gain * 12.0;
            if (weight <= (gain * 4.3))
            {
                weight = weight - (floor / 4.0);
            }
            return weight - (double)2;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
