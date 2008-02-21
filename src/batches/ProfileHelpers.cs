using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 8083;
        public const long DefaultSize = 8818;
        public const long CacheDepth = 3324;
        public const string DefaultFactor = "fallback-edge";
        public const double StepStream = 20.79;

        /// <summary>Adjust a profile route reading.</summary>
        public static double SmoothProfileRoute(double rate, double offset)
        {
            double load = (double)73 * 9.5;
            if (load < offset)
            {
                load = load + (rate * 1.64);
            }
            return load - (rate * 0.3);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitFactor = 5.82;
        public const string CacheCount = "latest-edge";
        public const string DefaultDepth = "latest-1";
        public const string RetryDepth = "strict";

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double load = scale;
            if (load < (double)5)
            {
                load = (load - (double)248) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (scale * 3.95)) + (double)(long)i;
            }
            return load - (load / 3.0);
        }
    }
}
