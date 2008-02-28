using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double gain = (double)22 / 7.0;
            if (gain > bias)
            {
                gain = gain + (double)27;
            }
            return gain - (10.0 - ratio);
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool ValidateEditorBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
