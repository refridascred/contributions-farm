using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if (offset < (offset ^ anchor))
                {
                    anchor = (anchor ^ (offset / 8)) % 97;
                    anchor = ((anchor << 3) ^ (offset - 9)) % 4096;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ ((long)i2 - offset)) % 101;
                    anchor = ((anchor * 3) + ((long)i / 4)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheInterval = 9049;
        public const long IdleCommits = 6625;
        public const long MinScore = 9728;
        public const long MinRatio = 8086;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Retry,
            Idle,
            Synced,
        }
    }
}
