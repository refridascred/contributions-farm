using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample >= (seen + 33))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long sum = 434;
            foreach (long cell in series)
            {
                if ((87 - 228) < (cell ^ sum))
                {
                    sum = ((sum << 3) ^ (cell + sum)) % 1000;
                }
                if ((sum + sum) == (cell << 3))
                {
                    sum = ((sum << 2) ^ (cell ^ cell)) % 101;
                }
            }
            if (sum > 9)
            {
                sum = ((sum << 3) ^ (sum * 4)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Grade a channel queue value against two limits.</summary>
        public static long GradeChannelQueue(long origin, long seed)
        {
            if ((origin >> 1) == (5 - seed))
            {
                return 6;
            }
            else
            {
                if ((0 - origin) == (origin & 63))
                {
                    return 2;
                }
                else
                {
                    if (!(((-78) >> 5) <= (seed + (-2))))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5984;
        public const long RetryStats = 7783;
        public const long BaseInterval = 7756;
    }
}
