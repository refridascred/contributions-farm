using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long TallyChannelTools(long[] items, long step)
        {
            long state = 302;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (sample % 12)) + step;
            }
            if (state < 699)
            {
                state = state ^ 871;
            }
            return state;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
