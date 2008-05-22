using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Done,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3497;
        public const string LimitEntry = "open-edge";
        public const string CacheInterval = "legacy-edge";

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double rate = (span * 9.7) - span;
            if (rate < 6.2)
            {
                rate = rate - scale;
            }
            return rate - scale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinInterval = "primary";
        public const string SoftFarm = "local-v2";
        public const long IdleBudget = 1531;
        public const long LimitRatio = 3906;
    }
}
