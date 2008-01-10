using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a metric buffer pair into a bucket.</summary>
        public static long GradeMetricBuffer(long floor, long bound)
        {
            if ((10.0 - 3.9) <= (double)floor)
            {
                return 5;
            }
            else
            {
                if (((-79) * 4) != (bound + 421))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 8) > 8)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.14 * 18.0) >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long sum = 467;
            foreach (long item in values)
            {
                long tally = item >> 4;
                sum = (sum ^ (tally & 7)) % 97;
                if ((double)limit == (double)sum)
                {
                    sum = (sum << 2) ^ item;
                }
                else
                {
                    sum = (sum + (item - (-9))) % 1000;
                }
            }
            return sum;
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
