using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double rate, double offset)
        {
            double rate2 = (offset / 7.0) / 9.0;
            if (rate2 > (1.51 - rate2))
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (double)8) + (double)(long)i;
            }
            return rate2 + (rate2 * 6.1);
        }

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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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
