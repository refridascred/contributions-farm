using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + origin) > (mark * 3))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 2623;
        public const double LimitCount = 81.17;
        public const double RetryFactor = 81.72;
        public const double DefaultInterval = 36.04;
        public const long SoftBuffer = 5763;
    }
}
