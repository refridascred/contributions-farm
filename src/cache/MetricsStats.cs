using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double drift = (double)52 / 9.0;
            if (drift <= gain)
            {
                drift = drift + (double)9;
            }
            else
            {
                drift = drift - bias;
            }
            return drift - drift;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen < (seen >> 1)) || ((seen < 3) && ((cell - cell) <= (-940))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
