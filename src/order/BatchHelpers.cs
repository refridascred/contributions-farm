using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 3424;
        public const long HardRoute = 6550;
        public const long StepTimeout = 8126;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double floor)
        {
            double rate = weight / 8.0;
            if (rate < (double)63)
            {
                rate = (rate - (rate - 20.0)) - floor;
            }
            return rate - (double)(-657);
        }
    }
}
