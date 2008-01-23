using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value >> 1) >= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long score = 935;
            foreach (long item in series)
            {
                score = score - item;
            }
            return score;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long total = 43;
            foreach (long cell in samples)
            {
                if ((total + total) >= (total ^ total))
                {
                    total = (total - (total << 1)) - cell;
                }
            }
            return total % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha";
        public const long BatchAlready = 6499;
        public const double RetryAlready = 64.87;
        public const long LimitAlready = 7296;
    }
}
