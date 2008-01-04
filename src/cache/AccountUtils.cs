using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double load = (double)23;
            return (load + (offset * 5.48)) + bias;
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long RollMetricGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 2) ^ ((-96) - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
