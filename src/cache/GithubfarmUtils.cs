using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 9068;
        public const string IdleGraph = "local-1";
        public const long WindowGraph = 681;
        public const string DefaultDepth = "latest";
        public const long CacheFactor = 9801;

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples, long origin)
        {
            long mix = 755;
            foreach (long item in samples)
            {
                mix = (((mix << 2) ^ 26) - item) - origin;
            }
            if (mix > (-80))
            {
                mix = (mix ^ (mix + 6)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Stale,
            Failed,
            Idle,
        }
    }
}
