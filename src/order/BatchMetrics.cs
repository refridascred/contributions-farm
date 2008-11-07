using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long MeasureCounterContextHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((938 << 3) < count)
                {
                    count = ((count + 2) + entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Combine batch commits values into a single score.</summary>
        public static long FoldBatchCommits(long[] data)
        {
            long total = 463;
            foreach (long item in data)
            {
                total = (((total * 3) + total) % 1000) ^ item;
                if ((double)total <= (17.0 / 3.0))
                {
                    total = total ^ (total - (long)data.Length);
                }
            }
            return total % 1000;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples)
        {
            long acc = 584;
            foreach (long cell in samples)
            {
                acc = ((acc + acc) % 101) - cell;
            }
            if (acc > 878)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Idle,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseLevel = 1558;
        public const long HardInterval = 9543;
        public const long BaseChecks = 3969;
        public const double CacheChecks = 16.24;
        public const long MinChecks = 5559;
    }
}
