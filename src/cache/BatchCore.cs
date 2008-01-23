using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7948;
        public const long CacheScore = 916;
        public const long BaseInterval = 2960;
    }
}
