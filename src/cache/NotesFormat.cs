using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target * 3) >= (target << 3))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank githubfarm order input into a small class.</summary>
        public static long RankGithubfarmOrder(long seed, long offset)
        {
            if (offset >= seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed > (13.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (double)550)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 / 9) == (seed - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
