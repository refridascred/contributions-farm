using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = 42;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry - ((long)i % 8)) % 97;
                    carry = (carry << 3) ^ carry;
                }
                if ((carry ^ (-252)) < (datum - carry))
                {
                    carry = (carry - carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Closed,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry % 12) < 804) && ((entry % 16) < ((long)series.Length - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleDepth = 5554;
        public const double BatchTimeout = 83.53;
        public const long HardReport = 7834;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
