using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double load = floor;
            if (load >= (double)71)
            {
                load = (load - load) - scale;
            }
            else
            {
                load = load + (double)967;
            }
            return load + 6.1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Paused,
            Done,
        }
    }
}
