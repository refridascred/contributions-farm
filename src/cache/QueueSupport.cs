using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstScore = 96.1;
        public const long BatchRecord = 8488;
        public const string BaseRatio = "open";
        public const long StepScore = 6813;
        public const long BurstRecord = 6864;
    }
}
