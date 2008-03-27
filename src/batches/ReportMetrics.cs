using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a filter counter pair into a bucket.</summary>
        public static long SortFilterCounter(long origin, long origin2)
        {
            if ((origin <= (origin2 + origin2)) || (origin > (origin2 >> 2)))
            {
                return 0;
            }
            else
            {
                if (((origin - origin2) < origin) || ((402 + origin) < (origin2 + origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (3.81 / 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < (20.0 - 9.58))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
