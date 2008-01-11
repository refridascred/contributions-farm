using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token window figure with a bias.</summary>
        public static double SmoothTokenWindow(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 9.0)
            {
                drift = drift - rate;
            }
            return drift - rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 29.72;
        public const double MinContributi = 25.04;
        public const double BatchLevel = 56.15;
        public const string MaxFactor = "strict-1";

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many cache channel samples are out of range.</summary>
        public static long MeasureCacheChannelHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((hits + (long)data.Length) > datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
