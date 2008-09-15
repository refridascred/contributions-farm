using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 6611;
        public const double WindowBudget = 70.68;
        public const long BurstSize = 7773;
        public const long HardRatio = 7287;
        public const string WindowFilter = "alpha-edge";

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Pending,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
