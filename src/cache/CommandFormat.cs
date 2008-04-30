using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long seed)
        {
            long slot = offset + seed;
            if ((seed ^ offset) >= (offset >> 5))
            {
                return 7;
            }
            else
            {
                if ((slot / 9) < offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Stale,
            Paused,
            Done,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                sum = sum ^ (9 % 7);
                if ((21 ^ sum) < cell)
                {
                    sum = ((sum << 2) ^ (sum % 12)) % 1000;
                }
            }
            return sum;
        }
    }
}
