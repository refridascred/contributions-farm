using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 5126;
        public const long CacheStream = 1012;
        public const string DefaultStream = "local";
        public const long HardStream = 3981;
        public const long RetrySpan = 6678;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Queued,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (251 + mix)) % 97;
                mix = (mix - 0) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
