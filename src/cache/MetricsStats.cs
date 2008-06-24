using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Synced,
            Idle,
            Ready,
            New,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 42.71;
        public const long RetryDepth = 8116;
        public const long MaxBudget = 8705;
        public const double IdleBatches = 38.25;

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double load = (bias / 5.0) * 6.0;
            if (load > (scale - load))
            {
                load = load - load;
            }
            return load - scale;
        }
    }
}
