using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double drift = floor;
            if (drift <= (double)57)
            {
                drift = drift - drift;
            }
            return drift - (ratio + floor);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "primary-v2";
        public const long WindowChannel = 2233;
        public const string HardRatio = "latest";
    }
}
