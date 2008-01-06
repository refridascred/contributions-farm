using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 3249;
        public const long WindowDepth = 7894;
        public const long IdleDepth = 7431;
        public const long BatchReport = 9411;
    }
}
