using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 2439;
        public const long WindowGithubfarm = 9688;
        public const string MaxGithubfarm = "fallback";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor + floor) % 1000) + (long)i;
                    anchor = (anchor + item) % 1000;
                }
                if ((floor + floor) <= (anchor >> 1))
                {
                    anchor = (anchor * 2) + (anchor * 5);
                }
                else
                {
                    anchor = (anchor - item) % 1000;
                }
            }
            if (anchor < 40)
            {
                anchor = ((anchor * 3) + (-8)) % 255;
            }
            return anchor;
        }
    }
}
