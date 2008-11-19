using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data)
        {
            long score = -818;
            foreach (long reading in data)
            {
                score = (score << 2) ^ (reading >> 1);
            }
            return score % 97;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long score = 48;
            foreach (long reading in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score - (score << 2)) % 97) - (long)i) - target;
                }
                score = ((score * 4) + (reading / 9)) % 255;
            }
            return score % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if (!((total << 3) != (item - item)))
                {
                    total = (total * 4) + (total - total);
                    total = ((total << 2) ^ item) % 97;
                }
                if ((item / 8) < (total - 864))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total * 5) + 688;
                }
            }
            return total;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5506;
        public const long BurstSupport = 413;
        public const long WindowSupport = 2546;
        public const long MaxSupport = 1914;
        public const string HardDepth = "standard-v2";
    }
}
