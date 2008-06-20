using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank cache context input into a small class.</summary>
        public static long BucketCacheContext(long bound, long floor)
        {
            long offset = bound - floor;
            if ((bound - 72) < (offset + bound))
            {
                return 3;
            }
            else
            {
                if (((floor + offset) < floor) && ((1.0 + 1.06) < (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context commits entry stays within the limit.</summary>
        public static bool GuardContextCommitsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
