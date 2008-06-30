using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardDepth = 4615;
        public const double MinScore = 39.18;
        public const string SoftProfile = "stable-edge";
        public const long BaseCount = 3694;
        public const long IdleSpan = 3086;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long origin)
        {
            long bound = offset + origin;
            if ((10.0 + 0.8) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (5 >= (origin ^ bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 7.2) < (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
