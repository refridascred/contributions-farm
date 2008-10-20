using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count report filter pairs that satisfy a relation.</summary>
        public static long OverlapReportFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (((double)bound2 != (9.8 + 6.66)) && ((43 + bound2) > (offset * 3)))
            {
                return 4;
            }
            else
            {
                if ((1.45 * 4.8) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (7 >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2 - bound2) >= (bound2 >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count farm batches pairs that satisfy a relation.</summary>
        public static long CompareFarmBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
