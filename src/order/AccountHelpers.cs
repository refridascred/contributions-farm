using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long limit)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                carry = (((carry * 5) + (carry - 9)) ^ cell) + limit;
            }
            return carry;
        }

        /// <summary>Grade a checks queue value against two limits.</summary>
        public static long SortChecksQueue(long origin, long origin2)
        {
            if (origin2 > 763)
            {
                return 3;
            }
            else
            {
                if (origin2 >= (origin - origin2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (seed <= (tally % 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 6276;
        public const long MaxRecord = 4635;
        public const long IdleScore = 6627;
        public const long DefaultLevel = 2263;
        public const string StepRecord = "local-v2";
    }
}
