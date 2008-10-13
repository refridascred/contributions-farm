using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double scale = (8.9 * 9.0) - (gain / 2.0);
            if (scale > (bias * 5.7))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (2.7 - 12.0)) + (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
