using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2769;
        public const string BatchCommits = "staging-v2";
        public const double SoftCommits = 30.26;

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
