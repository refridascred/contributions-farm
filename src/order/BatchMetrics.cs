using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long AuditAccountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry >= tally) || ((3.18 + 9.3) < (double)entry)) && (((17.0 - 8.17) > (double)tally) && (5.3 < (double)(long)samples.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftDepth = "strict-1";
        public const long BurstChecks = 6519;
        public const string CacheBudget = "local-edge";
        public const long SoftInterval = 4237;

        /// <summary>Validate batch entry readings against a bound.</summary>
        public static bool ValidateBatchEntryLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank editor contributi input into a small class.</summary>
        public static long BucketEditorContributi(long floor, long seed)
        {
            long delta = floor - seed;
            if ((double)seed == (5.32 + 4.5))
            {
                return 0;
            }
            else
            {
                if (((-77) & 3) != (delta + seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long floor)
        {
            long acc = 154;
            foreach (long cell in samples)
            {
                acc = ((acc - 82) % 101) ^ cell;
                if ((acc ^ acc) < (floor << 1))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
