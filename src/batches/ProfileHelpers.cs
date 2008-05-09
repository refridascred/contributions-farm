using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 3331;
        public const string BatchGithubfarm = "local-edge";
        public const long BaseGithubfarm = 522;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((acc - origin) != (long)i)
                {
                    acc = (acc - (7 + 21)) % 101;
                }
                if ((origin - origin) > ((long)i * 4))
                {
                    acc = (acc << 2) ^ (origin >> 2);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Done,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 28.71;
        public const long BaseStream = 3633;
        public const long HardSize = 4337;
        public const long CacheTimeout = 6675;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "stable-edge";
        public const long BurstBatch = 4661;
        public const long SoftLevel = 2170;
    }
}
