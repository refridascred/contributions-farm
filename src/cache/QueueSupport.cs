using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long bound, long limit)
        {
            if ((limit ^ 326) == (bound * 5))
            {
                return 8;
            }
            else
            {
                if (8.0 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((bound & 15) >= (89 * 5)) && ((13.0 + 5.9) == (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
