using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultDepth = "primary-edge";
        public const double BatchDepth = 80.27;
        public const long BaseTimeout = 3119;
        public const double StepCluster = 53.15;
        public const double LimitBudget = 83.2;
    }
}
