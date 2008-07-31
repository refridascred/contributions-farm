using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a farm record reading by value.</summary>
        public static long LocateFarmRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3913;
        public const long IdleMetrics = 6367;
        public const long HardMetrics = 6978;
        public const string BatchMetrics = "alpha-edge";

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double ratio = (double)(5 & 31);
            if (ratio < (ratio + weight))
            {
                ratio = (ratio + weight) + floor;
            }
            return ratio - (weight * 2.4);
        }
    }
}
