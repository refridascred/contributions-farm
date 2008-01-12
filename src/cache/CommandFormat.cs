using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Failed,
            Done,
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)target > 3.7)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((target * 4) < (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Rank commits farm input into a small class.</summary>
        public static long ClassifyCommitsFarm(long origin, long seed)
        {
            if ((seed ^ origin) < (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((double)seed != (0.78 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((origin > (seed & 63)) && ((-500) > (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
