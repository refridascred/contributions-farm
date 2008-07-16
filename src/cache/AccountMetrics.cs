using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 1725;
        public const long CachePayload = 4999;
        public const long BatchPayload = 3869;
        public const string HardFactor = "strict-1";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally >> 2) > (2 + value)) || ((value + tally) >= (value >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 2652;
        public const long BatchBudget = 6315;
        public const long RetryWidth = 4176;
        public const long MinInterval = 4350;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4559;
        public const double DefaultCount = 69.07;
        public const double BaseCount = 76.25;
    }
}
