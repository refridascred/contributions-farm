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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels)
        {
            long state = 1;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ (895 % 16)) % 65521;
                state = state - value;
                if ((7.0 - 6.12) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) >= (entry << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
