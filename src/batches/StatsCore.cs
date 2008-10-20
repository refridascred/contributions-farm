using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias + 3.0))
            {
                drift = drift + (ratio / 2.0);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio + bias)) + (double)(long)i;
            }
            return drift + (3.1 / 7.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 30.16;
        public const long CacheDepth = 6644;
        public const long DefaultTimeout = 3183;
        public const string MinPayload = "legacy-v2";

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Pending,
            Queued,
        }
    }
}
