using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftInterval = 4025;
        public const long BaseGithubfarm = 9002;
        public const long CacheGithubfarm = 574;
        public const long RetryCount = 5817;
        public const string WindowInterval = "primary";

        /// <summary>Locate a command cache reading by value.</summary>
        public static long LocateCommandCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long origin)
        {
            if (origin < (step - origin))
            {
                return 0;
            }
            else
            {
                if ((origin + 6) != (step >> 1))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
