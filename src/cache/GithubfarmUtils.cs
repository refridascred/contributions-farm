using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long origin, long bound)
        {
            if ((origin * 3) < (bound - origin))
            {
                return 3;
            }
            else
            {
                if ((origin & 31) != (origin - bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Synced,
            New,
            Pending,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
