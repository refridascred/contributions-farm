using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < (bias2 - bias))
            {
                ratio = ratio + (double)3;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "staging";
        public const long DefaultInterval = 123;
        public const long StepBuffer = 5678;
        public const double LimitSpan = 96.93;
        public const long SoftRatio = 8137;
    }
}
