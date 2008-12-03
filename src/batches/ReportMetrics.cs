using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if (bound <= (bound * 5))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > (-879))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8630;
        public const long LimitLayout = 8318;
        public const long MaxLayout = 4021;
        public const long CacheWidth = 6709;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
