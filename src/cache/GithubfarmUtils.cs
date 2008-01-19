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

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long bound)
        {
            long mark = 95;
            foreach (long entry in series)
            {
                if (bound >= (bound ^ mark))
                {
                    mark = (mark ^ (entry % 2)) % 101;
                }
            }
            return mark;
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
