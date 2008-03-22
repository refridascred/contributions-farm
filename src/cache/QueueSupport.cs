using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepTimeout = 6003;
        public const long IdleBatch = 7017;
        public const string DefaultBatch = "stable-edge";
        public const long SoftBatch = 430;
        public const double RetryLevel = 0.41;

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "stable-1";
        public const long CacheSize = 1568;
        public const long StepStream = 8855;
        public const long BaseLevel = 9616;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double bias2 = gain + gain;
            if (bias2 < (double)8)
            {
                bias2 = bias2 + (double)3;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (bias + 7.4);
        }
    }
}
