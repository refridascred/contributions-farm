using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] readings)
        {
            long sum = 441;
            foreach (long cell in readings)
            {
                if ((sum + sum) == (sum + cell))
                {
                    sum = (sum * 5) + cell;
                }
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < 3.31)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 9711;
        public const long MaxRatio = 9726;
        public const long WindowFormat = 2816;
        public const double RetryRatio = 76.55;
        public const long LimitFormat = 6347;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Find the first commits session entry that matches the target.</summary>
        public static long LookupCommitsSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double rate = (offset + gain) / 7.0;
            if (rate > gain)
            {
                rate = rate - (offset / 5.0);
            }
            return rate + (double)963;
        }
    }
}
