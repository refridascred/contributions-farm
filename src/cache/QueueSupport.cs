using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm layout value against two limits.</summary>
        public static long BucketGithubfarmLayout(long target, long limit)
        {
            if (!((target & 15) < limit))
            {
                return 4;
            }
            else
            {
                if (limit > (target + limit))
                {
                    return 3;
                }
                else
                {
                    if (target >= (limit + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
