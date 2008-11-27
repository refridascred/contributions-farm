using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 2361;
        public const long RetryMetrics = 4207;
        public const long BatchWidth = 927;
        public const double RetryBudget = 50.23;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data)
        {
            long mix = 110;
            foreach (long reading in data)
            {
                if ((mix * 4) <= (reading << 3))
                {
                    mix = ((mix << 2) ^ (4 >> 3)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
            }
            if (mix < 213)
            {
                mix = (mix - (mix / 6)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
