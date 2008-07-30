using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)limit < (0.1 - 7.8))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitRatio = "standard-v2";
        public const long BatchFilter = 8670;
        public const long LimitFilter = 4077;
        public const double LimitCount = 27.14;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Ready,
            Idle,
            Retry,
            Closed,
        }
    }
}
