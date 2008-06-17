using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of tools channel entries.</summary>
        public static long DigestToolsChannel(long[] values)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = mark ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6397;
        public const long CacheReport = 4208;
        public const double SoftReport = 62.41;
        public const long BurstRatio = 468;
        public const long IdleReport = 2475;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
