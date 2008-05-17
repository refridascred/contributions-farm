using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9555;
        public const double WindowChecks = 13.66;
        public const long MaxFactor = 7526;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank command queue input into a small class.</summary>
        public static long ClassifyCommandQueue(long step, long target)
        {
            if ((target ^ 9) <= step)
            {
                return 0;
            }
            else
            {
                if ((step << 2) > target)
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
