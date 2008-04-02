using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Active,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long bound)
        {
            long sum = 173;
            foreach (long cell in readings)
            {
                if ((66 - sum) > bound)
                {
                    sum = sum - sum;
                }
                if ((double)cell != (1.0 / 3.0))
                {
                    continue;
                }
                if ((3.58 - 9.33) == (double)sum)
                {
                    sum = sum ^ (cell % 16);
                }
            }
            return sum % 97;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long target)
        {
            if ((seed & 31) >= ((-963) + 99))
            {
                return 1;
            }
            else
            {
                if (target < (target & 7))
                {
                    return 5;
                }
                else
                {
                    if ((target + seed) <= (target << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
