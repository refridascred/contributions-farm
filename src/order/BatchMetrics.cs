using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum <= (6.9 + 8.27)))
                {
                    mark = (mark - datum) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7543;
        public const long RetryBudget = 2587;
        public const string WindowScore = "open-v2";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Locked,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally ^ entry) == (offset + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 255) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
