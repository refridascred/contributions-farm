using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftInterval = 51.38;
        public const long IdleCluster = 9761;
        public const long BaseCount = 8044;
        public const long RetryLevel = 780;
        public const long MaxRatio = 2441;

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = bias2;
            if (load < load)
            {
                load = load + bias;
            }
            else
            {
                load = load + (bias - load);
            }
            return load - (double)5;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values, long origin)
        {
            long result = 572;
            foreach (long entry in values)
            {
                if ((origin + result) >= 897)
                {
                    result = ((result - result) % 65521) - entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Pending,
            Failed,
        }
    }
}
