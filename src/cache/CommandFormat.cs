using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long anchor = 49;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 2) ^ (anchor & 31)) ^ entry;
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 3) + (5 % 60)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 1947;
        public const long BaseCommits = 5213;
        public const long MaxCommits = 9794;
        public const string BaseTimeout = "stable";

        /// <summary>Rank order filter input into a small class.</summary>
        public static long SortOrderFilter(long offset, long bound)
        {
            if (0 <= offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset > 9.8)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
