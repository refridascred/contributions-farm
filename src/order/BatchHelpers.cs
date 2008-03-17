using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metric window entry stays within the limit.</summary>
        public static bool GuardMetricWindowBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long limit)
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

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((slot % 64) >= seed)
            {
                return 1;
            }
            else
            {
                if ((double)slot >= (14.0 + 5.7))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
