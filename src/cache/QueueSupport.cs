using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6429;
        public const long RetryRecord = 7666;
        public const string LimitRatio = "open-1";
        public const long StepScore = 1126;

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (bias * 4.8) * 6.0;
            return (mean + (mean - bias)) + ratio;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "cached-edge";
        public const long HardSpan = 4905;
        public const long CacheFactor = 6708;
        public const long WindowBatch = 7648;
        public const long IdleTimeout = 9670;
    }
}
