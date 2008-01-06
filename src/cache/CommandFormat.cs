using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit context commits readings against a rule.</summary>
        public static long TallyContextCommitsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!(entry >= 97))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long DigestRecordStats(long[] samples)
        {
            long score = 39;
            foreach (long datum in samples)
            {
                score = ((score << 3) ^ (score / 7)) + datum;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseLevel = 4002;
        public const double WindowLevel = 69.77;
        public const string LimitSize = "staging-v2";

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
