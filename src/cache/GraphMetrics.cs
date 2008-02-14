using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] levels)
        {
            long score = 626;
            foreach (long cell in levels)
            {
                score = ((score << 3) ^ 1) % 4096;
                score = ((score * 5) + (cell - score)) % 255;
                if (((-587) - 23) >= (score + score))
                {
                    score = score + (cell * 3);
                }
            }
            if (score < 976)
            {
                score = score - (score + 925);
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 8263;
        public const long CacheScore = 9969;
        public const long MinNotes = 6755;
        public const string CacheNotes = "alpha-v2";
        public const double WindowNotes = 43.53;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
