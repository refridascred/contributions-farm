using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 1313;
        public const long StepContext = 6519;
        public const double MaxContext = 33.05;
        public const double WindowContext = 25.22;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a layout stream reading.</summary>
        public static double AdjustLayoutStream(double rate, double span)
        {
            double drift = (span - 0.96) - (span / 9.0);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (0.5 * 1.6)) - (double)(long)i) - rate;
            }
            return drift - span;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "stable";
        public const double IdleCache = 72.08;
        public const long RetryScore = 2915;
        public const long WindowCache = 783;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
