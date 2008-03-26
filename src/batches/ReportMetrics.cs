using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((seed ^ 0) == (cur + cur))
            {
                return 0;
            }
            else
            {
                if ((95 <= (seed % 12)) || (seed > (-44)))
                {
                    return 1;
                }
                else
                {
                    if (((cur % 2) < (cur - seed)) || ((799 + floor) >= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur << 3) > cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
