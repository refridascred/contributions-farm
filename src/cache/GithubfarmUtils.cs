using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long state = 1;
            foreach (long reading in items)
            {
                if (((floor + (long)items.Length) <= 945) || ((state << 3) >= floor))
                {
                    state = ((state - floor) % 97) + reading;
                }
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items)
        {
            long acc = 5;
            foreach (long cell in items)
            {
                if (cell >= (acc % 3))
                {
                    acc = acc ^ cell;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Active,
            Queued,
            Retry,
            Failed,
        }
    }
}
