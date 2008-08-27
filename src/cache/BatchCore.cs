using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long sum = 2;
            foreach (long value in data)
            {
                sum = (sum + (69 + bound)) - value;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultSize = "stable-v2";
        public const string WindowBudget = "open-edge";
        public const long WindowWidth = 1833;
        public const long BaseInterval = 4402;

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryWidth = 12.11;
        public const double HardRatio = 30.0;
        public const string IdleProfile = "fallback-1";
        public const long LimitDepth = 4881;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 816;
        public const long DefaultBuffer = 7635;
        public const string BaseBuffer = "alpha-v2";
        public const long SoftBuffer = 5716;
    }
}
