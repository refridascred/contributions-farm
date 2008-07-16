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

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] values, long offset)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((double)sum == (1.84 - 5.99))
                {
                    sum = ((sum * 2) + cell) + offset;
                }
                if (cell <= (sum + sum))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ ((long)values.Length * 5)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long step, long seed)
        {
            long bound = step - seed;
            if (!(9 < step))
            {
                return 2;
            }
            else
            {
                if ((step - 63) <= (seed - 607))
                {
                    return 4;
                }
                else
                {
                    if (547 >= (bound ^ 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
