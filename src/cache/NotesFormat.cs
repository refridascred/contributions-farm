using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the support commits series from a seed.</summary>
        public static long SeriesSupportCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Idle,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Rank githubfarm already input into a small class.</summary>
        public static long RankGithubfarmAlready(long offset, long floor)
        {
            long slot = offset + floor;
            if (((slot * 3) >= (floor >> 4)) || ((double)offset >= (19.0 - 0.01)))
            {
                return 8;
            }
            else
            {
                if ((slot - slot) <= (floor & 1))
                {
                    return 5;
                }
                else
                {
                    if (((floor - floor) >= offset) && ((floor + slot) < (slot >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset >> 3) > (floor % 10)))
                        {
                            return 7;
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
}
