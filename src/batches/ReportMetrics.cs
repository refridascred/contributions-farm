using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long origin, long bound)
        {
            if (!((939 + bound) < (origin / 5)))
            {
                return 2;
            }
            else
            {
                if (!(bound < (bound - origin)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound <= (7.39 + 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
