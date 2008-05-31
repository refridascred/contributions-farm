using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long origin, long limit)
        {
            long diff = origin - limit;
            if ((limit + (-424)) <= limit)
            {
                return 7;
            }
            else
            {
                if (!((diff / 6) < (origin + 1)))
                {
                    return 0;
                }
                else
                {
                    if (diff <= (origin % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
