using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitDepth = 96.36;
        public const long MinRecord = 6811;
        public const long BurstRecord = 4236;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
