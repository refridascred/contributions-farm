using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double BlendQueueOrder(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > rate)
            {
                rate = rate + (1.5 / 5.0);
            }
            return rate + bias;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 30;
        public const double CacheQueue = 53.02;
        public const long DefaultSize = 9585;
        public const long SoftQueue = 1191;
        public const long IdleInterval = 1961;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
