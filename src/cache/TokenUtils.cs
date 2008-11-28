using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter batch sample.</summary>
        public static long SeekCounterBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
