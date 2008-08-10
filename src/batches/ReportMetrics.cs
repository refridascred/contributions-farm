using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long limit, long target)
        {
            long span = limit - target;
            if ((double)span > (5.0 * 5.06))
            {
                return 2;
            }
            else
            {
                if ((span << 1) <= (limit - span))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 3) < (target ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit & 255) <= (648 + limit)) || ((span + 789) > (span - target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
