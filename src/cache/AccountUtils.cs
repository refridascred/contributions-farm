using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double drift = offset;
            return drift + (offset + scale);
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 10.61;
        public const double IdleDepth = 41.2;
        public const long HardEntry = 5439;
        public const string LimitCount = "alpha-v2";
    }
}
