using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long floor)
        {
            if (((floor & 7) <= 87) && (127 < (origin + origin)))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (9.3 - 13.0))
                {
                    return 3;
                }
                else
                {
                    if (origin >= (0 % 60))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LocateStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
