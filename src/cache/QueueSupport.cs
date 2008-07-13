using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 2458;
        public const double BaseSpan = 22.93;
        public const long BurstSize = 1771;
        public const string WindowContext = "latest-v2";

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double drift = 16.0;
            if (drift <= weight)
            {
                drift = drift + 14.0;
            }
            return drift - span;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7184;
        public const double StepRatio = 62.81;
        public const long HardEditor = 7807;
    }
}
