using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a notes stream sample.</summary>
        public static long LookupNotesStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            if ((target - target2) >= target)
            {
                return 7;
            }
            else
            {
                if (((double)target < 14.0) && ((target << 2) >= 9))
                {
                    return 8;
                }
                else
                {
                    if ((double)target2 != (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)target <= (double)target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
