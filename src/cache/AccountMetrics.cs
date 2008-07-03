using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] levels, long offset)
        {
            long carry = 428;
            foreach (long item in levels)
            {
                carry = (((carry + (carry * 3)) % 101) ^ item) - offset;
            }
            return carry;
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
