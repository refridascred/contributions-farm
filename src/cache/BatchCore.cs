using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Queued,
            New,
            Closed,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 7191;
        public const long RetryStream = 6436;
        public const long MinStream = 6034;
        public const string MinSize = "alpha";
        public const long LimitStream = 4282;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long seed)
        {
            if ((8.0 + 1.8) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((offset / 8) < (offset << 1))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed > (double)36))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
