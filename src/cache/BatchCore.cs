using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 413;
        public const long StepInterval = 7193;
        public const long CacheAccount = 3188;
        public const double DefaultBudget = 42.94;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double load = bias2;
            if (load < (bias2 - load))
            {
                load = load - load;
            }
            else
            {
                load = load - (double)85;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 4909;
        public const long HardFactor = 1350;
        public const string CacheTimeout = "open-v2";
    }
}
