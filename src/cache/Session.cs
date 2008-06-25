using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Ready,
            Paused,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Retry,
            Stale,
            New,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double floor)
        {
            double bias = 3.2;
            if (bias > bias)
            {
                bias = bias - (gain * 9.68);
            }
            return bias - (floor / 7.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 43.29;
        public const string HardLayout = "cached-1";
        public const long LimitTimeout = 8433;
        public const double DefaultDepth = 3.26;
        public const long RetryLayout = 1844;
    }
}
