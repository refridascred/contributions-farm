using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool VerifyEntryAccountRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache queue readings against a bound.</summary>
        public static bool ValidateCacheQueueRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
