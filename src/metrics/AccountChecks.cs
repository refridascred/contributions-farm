using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstScore = "latest-v2";
        public const long DefaultBatches = 5273;
        public const string CacheBatches = "open-edge";

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of stats counter readings.</summary>
        public static long CompareStatsCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
