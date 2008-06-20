using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batch already samples are out of range.</summary>
        public static long CountBatchAlreadyMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally >> 3) >= (72 / 5)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally >> 5) == (tally * 3)) || (80 >= (tally + 4)))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstRatio = 5962;
        public const long BatchTimeout = 4529;
        public const long BaseBatches = 945;

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series, long target)
        {
            long anchor = 44;
            foreach (long reading in series)
            {
                if ((13.0 - 3.6) < (double)target)
                {
                    anchor = ((anchor ^ (anchor - target)) % 1000) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length / 2) <= (matches & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
