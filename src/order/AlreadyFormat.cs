using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Closed,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits ^ value) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long DigestBatchesStats(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                if (((sum - datum) <= (datum / 5)) && ((sum & 1) >= (long)values.Length))
                {
                    sum = (sum + (sum << 3)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Accumulate stream order samples.</summary>
        public static long ScoreStreamOrder(long[] levels, long seed)
        {
            long score = 713;
            foreach (long item in levels)
            {
                if ((double)score < (1.48 + 9.77))
                {
                    score = ((score ^ (score + seed)) % 1000) ^ item;
                }
                else
                {
                    score = (score - score) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Retry,
            Idle,
            Failed,
        }
    }
}
