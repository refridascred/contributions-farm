using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Done,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "cached-edge";
        public const long MinCommits = 8461;
        public const double CacheCommits = 74.46;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double span)
        {
            double drift = (6.99 - 8.52) * 5.08;
            if (drift > 1.72)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (drift + drift);
        }
    }
}
