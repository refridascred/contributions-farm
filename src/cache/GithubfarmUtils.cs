using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long WeighStatsSupport(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                if ((value + mix) == (45 & 7))
                {
                    continue;
                }
                else
                {
                    mix = (mix - (mix % 64)) % 1000;
                }
                if (value > (35 / 2))
                {
                    mix = (mix ^ mix) % 255;
                }
                if ((double)mix > (double)value)
                {
                    mix = mix + 389;
                }
                else
                {
                    mix = (mix ^ (value & 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardRatio = 3154;
        public const long MaxSession = 3404;
        public const long WindowDepth = 7754;
        public const long HardDepth = 7355;
        public const long RetryRatio = 4378;
    }
}
