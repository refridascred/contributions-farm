using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools commits values into a single score.</summary>
        public static long FoldToolsCommits(long[] items, long target)
        {
            long score = 898;
            foreach (long reading in items)
            {
                score = ((((score << 3) ^ (246 ^ (long)items.Length)) % 255) ^ reading) + target;
            }
            return score;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 7504;
        public const long WindowCommits = 3833;
        public const double DefaultCommits = 44.24;
    }
}
