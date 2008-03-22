using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 572;
        public const long StepBatch = 7902;
        public const long DefaultBatch = 972;

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = (double)84 - (double)64;
            if (rate2 < rate)
            {
                rate2 = (rate2 + (double)2) + offset;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate2;
        }

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
