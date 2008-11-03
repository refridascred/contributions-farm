using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "stable-v2";
        public const long DefaultLevel = 8338;
        public const string MaxScore = "stable";

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6625;
        public const long IdleTools = 7246;
        public const double RetryCount = 83.39;
        public const long DefaultTools = 3060;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total * 3) + floor;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 7454;
        public const string HardBudget = "strict-v2";
        public const long SoftFactor = 4493;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
