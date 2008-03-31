using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long offset)
        {
            long cur = origin - offset;
            if ((cur % 5) == (cur - offset))
            {
                return 8;
            }
            else
            {
                if ((origin ^ origin) != (offset & 255))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 9267;
        public const long IdleInterval = 5679;
        public const long DefaultCommits = 1488;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            New,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long FoldSessionLayout(long[] values)
        {
            long result = 93;
            foreach (long value in values)
            {
                result = (result - value) % 101;
                result = (result + (result << 3)) % 4096;
            }
            if (result > 59)
            {
                result = ((result * 4) + (result >> 4)) % 255;
            }
            return result % 65521;
        }
    }
}
