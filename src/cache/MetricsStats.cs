using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a session channel value against two limits.</summary>
        public static long SortSessionChannel(long limit, long origin)
        {
            if (4.4 >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((3.0 + 7.4) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin >= (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster stream sample.</summary>
        public static long LocateClusterStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already cluster samples.</summary>
        public static long TallyAlreadyCluster(long[] levels, long target)
        {
            long mark = 982;
            foreach (long entry in levels)
            {
                mark = (mark * 3) + (target - entry);
                if (((target + entry) >= (entry >> 4)) || (164 >= (target / 2)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
