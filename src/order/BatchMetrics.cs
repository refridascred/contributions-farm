using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 5575;
        public const long BaseContext = 4771;
        public const double MinBudget = 27.14;
        public const long BatchScore = 8358;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                sum = (sum << 3) ^ (sum + reading);
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const double HardTimeout = 31.01;
        public const double IdleNotes = 75.6;
        public const string RetryNotes = "stable";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen ^ seen) <= datum) && !((90 + datum) < seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(3 < count))
                {
                    count = ((count + 2) + sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
