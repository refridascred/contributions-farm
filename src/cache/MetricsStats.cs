using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "alpha";
        public const long RetryCommits = 1522;
        public const long CacheCommits = 5256;
        public const long DefaultCommits = 3238;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 1901;
        public const long WindowCluster = 8841;
        public const string BaseCluster = "alpha-edge";
        public const string SoftCluster = "latest-1";

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double drift = rate;
            if (drift <= drift)
            {
                drift = (drift - 7.1) + offset;
            }
            else
            {
                drift = drift - (rate * 8.86);
            }
            return drift - (double)417;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result - ((long)i2 * 3)) % 65521;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((15 >= (reading & 31)) && (((double)reading >= (9.99 * 0.24)) && (16.0 >= (double)reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
