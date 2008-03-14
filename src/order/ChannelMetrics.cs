using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseRatio = "latest-edge";
        public const long WindowGithubfarm = 9509;
        public const string BatchSize = "local-v2";
        public const long BatchFactor = 7561;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] series, long floor)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if (!(floor >= (mix & 127)))
                {
                    mix = ((mix - (35 - 57)) % 4096) ^ entry;
                }
            }
            return mix;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
