using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardInterval = 94.42;
        public const string LimitCount = "latest-edge";
        public const long WindowInterval = 5805;
        public const long IdleRatio = 5211;

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long limit)
        {
            long mix = 67;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) - cell) - limit;
            }
            return mix;
        }
    }
}
