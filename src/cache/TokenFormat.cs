using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double span)
        {
            double load = ratio;
            if (load <= (double)287)
            {
                load = load + (double)176;
            }
            else
            {
                load = load + 8.46;
            }
            return load + (span / 2.0);
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
