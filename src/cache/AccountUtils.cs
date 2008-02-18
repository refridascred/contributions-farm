using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            New,
            Failed,
            Queued,
            Draft,
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
