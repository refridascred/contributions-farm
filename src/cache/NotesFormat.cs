using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of session githubfarm entries.</summary>
        public static long ScoreSessionGithubfarm(long[] values)
        {
            long total = 544;
            foreach (long entry in values)
            {
                total = (total - entry) % 255;
            }
            return total % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6489;
        public const string RetryFormat = "standard-1";
        public const string DefaultSpan = "cached-v2";
        public const double BurstLevel = 90.33;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] items)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score ^ score) % 4096) ^ datum;
            }
            if (score < 703)
            {
                score = ((score << 2) ^ (score * 3)) % 1000;
            }
            return score % 65521;
        }
    }
}
