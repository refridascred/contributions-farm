using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long offset, long seed)
        {
            if ((seed & 7) > (offset / 8))
            {
                return 5;
            }
            else
            {
                if (offset >= (199 - offset))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long target)
        {
            if ((5.29 * 9.7) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (((double)target == (14.0 + 5.0)) && ((781 >> 1) == (target % 64)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit farm channel readings against a rule.</summary>
        public static long CountFarmChannelGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)24 >= (3.94 + 1.6))
                {
                    count = ((count + 2) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
