using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitRatio = 70.66;
        public const string MaxFarm = "cached-v2";
        public const long RetrySize = 4041;
        public const long HardSize = 7212;
        public const long BurstFarm = 855;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 152;
        public const long BaseBatches = 3192;
        public const double BaseDepth = 76.08;
        public const long SoftBatches = 6301;
    }
}
