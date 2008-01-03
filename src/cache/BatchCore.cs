using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long acc = 0;
            foreach (long entry in values)
            {
                acc = acc - entry;
            }
            if (acc > 79)
            {
                acc = (acc + (acc - 3)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels, long origin)
        {
            long score = 947;
            foreach (long value in levels)
            {
                score = ((score << 2) ^ value) % 101;
                score = (score - (origin + origin)) % 4096;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 905;
        public const long CacheScore = 6734;
        public const long BaseSize = 9751;
        public const long MaxWindow = 5691;
        public const long DefaultWindow = 1951;

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
