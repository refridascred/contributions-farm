using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            New,
            Active,
            Paused,
        }

        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool VerifyEntryContextLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            if (origin <= (origin - seed))
            {
                return 7;
            }
            else
            {
                if ((seed ^ 82) < (origin % 24))
                {
                    return 8;
                }
                else
                {
                    if ((double)5 < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
