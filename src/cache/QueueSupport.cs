using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric cache pair into a bucket.</summary>
        public static long GradeMetricCache(long target, long target2)
        {
            long gap = target + target2;
            if (((1.0 / 3.0) != (double)gap) && ((double)gap != (1.95 / 6.0)))
            {
                return 3;
            }
            else
            {
                if ((target << 2) >= target2)
                {
                    return 7;
                }
                else
                {
                    if ((104 > (gap / 5)) && ((5.0 / 9.0) == (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
