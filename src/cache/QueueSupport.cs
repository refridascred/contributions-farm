using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitScore = 78.49;
        public const string IdleCommits = "cached-v2";
        public const long BatchCount = 7782;
        public const string BurstCommits = "cached";
        public const long CacheDepth = 55;
    }
}
