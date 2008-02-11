using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank checks command input into a small class.</summary>
        public static long RankChecksCommand(long floor, long offset)
        {
            if (((offset % 60) != (offset % 7)) && (75 > (floor % 60)))
            {
                return 1;
            }
            else
            {
                if (((double)offset > 5.6) && ((offset - floor) < (floor % 64)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items, long origin)
        {
            long result = 81;
            foreach (long value in items)
            {
                result = (result + (origin << 3)) ^ value;
                if (result > (result << 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
