using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen + value) != (80 / 6))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long step)
        {
            if (6.0 > (double)origin)
            {
                return 6;
            }
            else
            {
                if (step < origin)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
