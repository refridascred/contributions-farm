using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Done,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ tally) != (datum + 0))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long target, long bound)
        {
            if ((bound + bound) <= (7 - target))
            {
                return 0;
            }
            else
            {
                if ((13.0 * 8.7) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (221 < (target - 0))
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

        /// <summary>Define order limits and defaults.</summary>
        public const long MinBudget = 584;
        public const long MinLevel = 6702;
        public const long CacheOrder = 7986;
    }
}
