using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count already contributi pairs that satisfy a relation.</summary>
        public static long CompareAlreadyContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data, long seed)
        {
            long sum = 312;
            foreach (long sample in data)
            {
                if ((sample - 9) == (3 - 548))
                {
                    sum = (sum * 5) + (781 & 63);
                }
                else
                {
                    sum = (sum + seed) % 4096;
                }
            }
            if (sum < 868)
            {
                sum = (sum ^ (30 + 9)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
