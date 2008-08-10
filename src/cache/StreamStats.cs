using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySize = 1430;
        public const string LimitSupport = "alpha-v2";
        public const long SoftSupport = 2105;
        public const double BurstSupport = 70.42;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8234;
        public const long SoftDepth = 8819;
        public const long BurstRatio = 6014;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((9.57 * 2.81) == (double)count) || ((double)item != (double)0)) || ((6.0 - 18.0) == (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
