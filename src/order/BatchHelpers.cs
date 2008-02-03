using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer stream samples.</summary>
        public static long CompareBufferStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxCount = 92.41;
        public const string CacheRecord = "strict-1";
        public const string HardRecord = "staging-edge";
        public const long StepScore = 2765;
        public const string MaxFactor = "local-edge";

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Closed,
            New,
        }
    }
}
