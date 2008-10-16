using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((floor * 4) > limit)
            {
                return 8;
            }
            else
            {
                if (limit <= (floor * 4))
                {
                    return 0;
                }
                else
                {
                    if ((limit / 2) < (floor & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.52 / 6.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
