using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 48.47;
        public const long BaseStream = 9493;
        public const long BaseScore = 4526;

        /// <summary>Digest a series of tools entry entries.</summary>
        public static long DigestToolsEntry(long[] items)
        {
            long score = -561;
            foreach (long cell in items)
            {
                if ((double)score > (6.0 / 9.0))
                {
                    score = score - (cell * 5);
                }
            }
            return score % 97;
        }
    }
}
