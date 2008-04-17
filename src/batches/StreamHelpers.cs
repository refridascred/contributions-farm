using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 78;
            foreach (long value in samples)
            {
                if ((double)carry < (double)5)
                {
                    carry = carry ^ (value + value);
                }
                else
                {
                    carry = ((carry * 3) + (value + value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Count the report stream entries that pass the check.</summary>
        public static long AuditReportStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + value) == (count + count)) || !((value ^ value) >= value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSpan = "staging";
        public const long StepAccount = 9957;
        public const double RetryRatio = 79.63;
        public const long MinAccount = 7969;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinScore = 9004;
        public const double DefaultMetrics = 7.4;
        public const long BatchWidth = 2931;

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (((-299) >> 4) >= (94 ^ prev))
            {
                return 7;
            }
            else
            {
                if ((seed % 8) == (origin * 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
