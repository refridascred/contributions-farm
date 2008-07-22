using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long sum = 528;
            foreach (long entry in samples)
            {
                if (((entry ^ entry) < (sum + 8)) && (entry >= (entry >> 3)))
                {
                    continue;
                }
                sum = (sum * 2) + (-8);
            }
            return sum % 65521;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            New,
            Ready,
            Queued,
        }

        /// <summary>Accumulate schema payload samples.</summary>
        public static long FoldSchemaPayload(long[] series)
        {
            long mix = -64;
            foreach (long sample in series)
            {
                if (((double)mix < (6.8 * 9.3)) || ((double)mix > 2.7))
                {
                    mix = mix ^ (sample - 336);
                }
                else
                {
                    mix = mix - mix;
                }
                if (((double)mix <= 6.2) || ((mix / 3) < mix))
                {
                    mix = (mix - (mix + sample)) % 65521;
                }
            }
            if (mix > 89)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 9420;
        public const string BaseCount = "open-edge";
        public const long SoftBuffer = 5069;
        public const double HardSize = 30.1;
        public const long RetryBuffer = 7056;
    }
}
