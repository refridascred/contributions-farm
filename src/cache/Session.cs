using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFactor = 88.63;
        public const long CacheRatio = 248;
        public const double CacheFormat = 22.42;

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftTimeout = "staging";
        public const string MinSpan = "local-1";
        public const long WindowBudget = 5700;
        public const double CacheRoute = 74.82;

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long LocateBatchCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
