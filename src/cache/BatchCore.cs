using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Locked,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long origin)
        {
            if (origin >= (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((7.1 + 8.0) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a metric graph value against two limits.</summary>
        public static long SortMetricGraph(long origin, long origin2)
        {
            if ((double)origin2 != (7.4 - 13.0))
            {
                return 0;
            }
            else
            {
                if ((origin2 + (-268)) != (origin2 + origin2))
                {
                    return 3;
                }
                else
                {
                    if ((origin2 > (origin - origin)) && ((origin - origin) <= origin2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
