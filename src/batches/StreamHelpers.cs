using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3770;
        public const string BaseCommand = "strict";
        public const long BurstDepth = 415;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5555;
        public const double LimitContext = 90.3;
        public const long WindowDepth = 1450;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double bias2 = bias - (gain - gain);
            if (bias2 >= (double)4)
            {
                bias2 = bias2 + bias;
            }
            return bias2 + (double)8;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowFactor = 1312;
        public const long IdleContext = 7506;
        public const long BatchContext = 5996;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Closed,
            Pending,
            Active,
        }
    }
}
