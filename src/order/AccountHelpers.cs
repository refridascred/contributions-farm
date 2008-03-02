using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardTimeout = 40.24;
        public const double LimitChannel = 14.84;
        public const string CacheRatio = "strict-1";

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double mean = (double)(3 - 89);
            if (mean <= (13.0 + 3.0))
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.42 + floor)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result << 3) ^ (result / 2)) ^ (long)i2;
                    result = result - (result >> 2);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinSpan = "local-edge";
        public const string BaseCommits = "legacy-1";
        public const string MinFactor = "alpha-1";
        public const long IdleLevel = 2429;

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
