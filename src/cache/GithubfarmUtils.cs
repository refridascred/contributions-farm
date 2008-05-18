using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long AuditContextFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= 0.27)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long limit)
        {
            if ((origin + origin) > origin)
            {
                return 4;
            }
            else
            {
                if ((7.1 + 4.1) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((limit % 10) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Locate a stream commits reading by value.</summary>
        public static long LocateStreamCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
