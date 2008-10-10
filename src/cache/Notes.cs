using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((0.68 / 4.0) > (double)count) && ((double)count >= 1.0)))
                {
                    count = ((count + 3) + value) + floor;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 662;
        public const long BurstAccount = 4638;
        public const long LimitTimeout = 1879;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 130;
        public const long LimitDepth = 7972;
        public const long LimitSize = 632;

        /// <summary>Adjust a already cache reading.</summary>
        public static double ScaleAlreadyCache(double gain, double offset)
        {
            double ratio = (double)(9 - 1);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - ratio) - (double)(long)i) - gain) + offset;
            }
            return ratio + (ratio * 5.0);
        }
    }
}
