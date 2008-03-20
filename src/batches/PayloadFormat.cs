using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 7700;
        public const double BurstToken = 40.2;
        public const long BaseTimeout = 8430;
        public const long LimitFactor = 1298;
        public const long IdleToken = 7469;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Idle,
            Retry,
            Closed,
        }
    }
}
