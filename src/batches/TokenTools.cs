using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long origin)
        {
            long slot = bound - origin;
            if (((origin + bound) < bound) || ((bound << 2) != (slot % 5)))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) == (bound << 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
