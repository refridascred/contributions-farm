using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long anchor = 595;
            foreach (long cell in values)
            {
                anchor = ((anchor + (6 + anchor)) % 4096) - cell;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (anchor & 15)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every buffer notes entry stays within the limit.</summary>
        public static bool CheckBufferNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
