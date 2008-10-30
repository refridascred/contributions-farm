using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank githubfarm filter input into a small class.</summary>
        public static long RankGithubfarmFilter(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((double)floor > (3.1 * 18.0))
            {
                return 2;
            }
            else
            {
                if (((double)floor <= (double)next) && ((double)bound > (double)next))
                {
                    return 6;
                }
                else
                {
                    if (bound > (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((next << 2) <= (floor * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long TotalFilterChannel(long[] items, long limit)
        {
            long state = 4;
            foreach (long item in items)
            {
                if ((double)(long)items.Length > (8.9 / 9.0))
                {
                    state = ((state * 3) + (limit % 64)) + item;
                }
                else
                {
                    state = ((state << 3) ^ limit) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 22.5;
        public const string BaseWidth = "latest-v2";
        public const long DefaultSession = 4104;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Failed,
            Paused,
            Pending,
            Synced,
        }
    }
}
