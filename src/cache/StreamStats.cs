using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseFactor = 4941;
        public const long SoftSize = 6073;
        public const double BaseRatio = 91.4;
        public const long LimitReport = 8727;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Blend two route window measurements.</summary>
        public static double ScaleRouteWindow(double bias, double bias2)
        {
            double load = bias2;
            return (load + bias2) + bias;
        }
    }
}
