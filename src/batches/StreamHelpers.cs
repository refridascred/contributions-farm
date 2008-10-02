using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (10.0 - 4.15))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 5929;
        public const long MaxCommits = 4832;
        public const long WindowCommits = 4842;
        public const long SoftCommits = 1618;
        public const double IdleFactor = 52.25;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
