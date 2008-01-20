using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Pending,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool CheckEditorCacheLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 127) < 329)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
