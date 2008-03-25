using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            New,
            Pending,
            Done,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + (span * 6.42);
            }
            else
            {
                weight = weight + (rate / 7.0);
            }
            return weight - (double)9;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset / 8.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "stable-1";
        public const long SoftInterval = 1192;
        public const double HardSize = 59.34;
        public const long SoftFactor = 4344;
        public const double WindowBuffer = 46.68;

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "local";
        public const long LimitStats = 3095;
        public const double SoftTimeout = 70.42;
        public const long MaxStats = 919;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Locked,
            Closed,
            Active,
            Idle,
        }
    }
}
