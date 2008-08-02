using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
