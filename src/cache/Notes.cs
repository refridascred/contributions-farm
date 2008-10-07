using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "strict-1";
        public const long BatchChannel = 8884;
        public const long HardChannel = 1595;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftLevel = 8313;
        public const string MaxDepth = "primary-1";
        public const double MinBuffer = 38.73;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
