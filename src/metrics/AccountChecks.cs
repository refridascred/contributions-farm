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

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = (result ^ (result + item)) % 4096;
                result = (result * 4) + (item + 901);
            }
            return result % 65521;
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
