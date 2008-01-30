using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine batch batches values into a single score.</summary>
        public static long FoldBatchBatches(long[] series)
        {
            long carry = 44;
            foreach (long value in series)
            {
                if (!(((2.79 / 5.0) > (4.08 / 5.0)) || ((82 + (long)series.Length) >= ((long)series.Length - value))))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 5) + (value / 5)) % 101;
            }
            if (carry > 8)
            {
                carry = ((carry << 2) ^ (84 & 63)) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a notes metric pair into a bucket.</summary>
        public static long RankNotesMetric(long origin, long floor)
        {
            if ((origin + origin) != (floor * 5))
            {
                return 2;
            }
            else
            {
                if (!((floor * 2) < 326))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 4) > 59)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 5691;
        public const long BurstCount = 2242;
        public const double StepWidth = 64.5;
        public const double HardCount = 89.95;
        public const double MaxAlready = 47.18;

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 3981;
        public const long BaseBudget = 2112;
        public const double SoftGraph = 66.9;
        public const string LimitGraph = "cached-v2";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "primary-1";
        public const string SoftCluster = "primary-1";
        public const long CacheCluster = 8055;
        public const double BaseScore = 6.37;
        public const double LimitDepth = 29.03;
    }
}
