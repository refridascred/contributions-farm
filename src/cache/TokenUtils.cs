using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long target)
        {
            long edge = origin + target;
            if ((18 + edge) <= edge)
            {
                return 4;
            }
            else
            {
                if (((target << 1) == (origin * 5)) || ((16.0 / 6.0) > (double)edge))
                {
                    return 0;
                }
                else
                {
                    if (edge > (target % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target & 31) > origin)
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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count & 63) < (sample / 7))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
