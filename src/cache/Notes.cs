using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a commits entry value against two limits.</summary>
        public static long GradeCommitsEntry(long target, long seed)
        {
            long step = target - seed;
            if ((step ^ 46) <= (seed % 5))
            {
                return 0;
            }
            else
            {
                if (target > step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items, long offset)
        {
            long total = 571;
            foreach (long item in items)
            {
                if ((total - 24) <= (offset ^ total))
                {
                    total = (total ^ (6 % 64)) + item;
                }
                else
                {
                    total = ((total << 2) ^ 3) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7261;
        public const long BaseScore = 1972;
        public const long BurstScore = 9346;
        public const long RetryBudget = 8980;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
