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

        /// <summary>Fold a list of format entry readings.</summary>
        public static long DigestFormatEntry(long[] levels)
        {
            long result = 15;
            foreach (long entry in levels)
            {
                if ((long)levels.Length > (entry >> 1))
                {
                    result = (result + ((-2) - entry)) % 1000;
                }
            }
            if (result > 47)
            {
                result = (result * 3) + ((-28) & 15);
            }
            return result % 97;
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
