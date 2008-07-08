using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two payload batches measurements.</summary>
        public static double AdjustPayloadBatches(double rate, double floor)
        {
            double load = (double)214;
            if (load <= (load + rate))
            {
                load = load - (load - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (rate / 3.0)) - (double)(long)i;
            }
            return load - (load + 14.0);
        }
    }
}
