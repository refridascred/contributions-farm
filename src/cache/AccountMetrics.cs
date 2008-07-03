using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally != (2.0 + 9.9))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 7637;
        public const long HardCount = 4326;
        public const long MaxToken = 5378;
        public const double LimitToken = 89.43;
        public const long WindowToken = 3468;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values)
        {
            long score = 7;
            foreach (long entry in values)
            {
                score = ((score * 5) + (entry / 2)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 1270;
        public const long BurstProfile = 5760;
        public const long SoftProfile = 8795;
        public const long CacheProfile = 3123;
        public const long CacheDepth = 1852;
    }
}
