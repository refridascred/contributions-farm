using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metric schema samples.</summary>
        public static long OverlapMetricSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 15) >= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long sum = 3;
            foreach (long value in series)
            {
                if (((bound + bound) < (961 << 1)) && ((value + value) >= (value & 31)))
                {
                    sum = (sum << 2) ^ value;
                    break;
                }
                if ((sum - value) != (sum + value))
                {
                    sum = (sum - (sum ^ bound)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Draft,
            Closed,
            New,
        }

        /// <summary>Classify a cache filter pair into a bucket.</summary>
        public static long BucketCacheFilter(long seed, long bound)
        {
            if (bound <= seed)
            {
                return 3;
            }
            else
            {
                if (((4.0 / 6.0) <= (double)bound) && ((seed + seed) == (bound >> 1)))
                {
                    return 5;
                }
                else
                {
                    if ((13 + seed) == (5 * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound < (3.85 - 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
