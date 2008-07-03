using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of commits token entries.</summary>
        public static long CombineCommitsToken(long[] series)
        {
            long carry = 67;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + ((-855) >> 4)) % 1000;
                if ((sample + carry) == (sample >> 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value < 2.4)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((108 ^ hits) < ((long)data.Length ^ cell)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
