using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((7 - tally) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) <= (reading << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long total = -5;
            foreach (long reading in samples)
            {
                if ((total + 100) <= (total + total))
                {
                    total = (((total << 3) ^ (total + 652)) % 1000) ^ reading;
                }
            }
            if (total > 11)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftLevel = "local-1";
        public const long BaseSpan = 7287;
        public const long MaxProfile = 8038;
        public const long CacheProfile = 4787;
        public const long StepWidth = 9364;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
