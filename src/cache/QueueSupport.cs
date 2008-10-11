using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value >= 4.58)
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstLevel = 8011;
        public const long CacheScore = 8032;
        public const long MinCount = 4239;
        public const string CacheDepth = "alpha";
    }
}
