using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long floor)
        {
            long bound = limit ^ floor;
            if (bound >= limit)
            {
                return 1;
            }
            else
            {
                if (limit < (40 - floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Closed,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowInterval = 83.3;
        public const string SoftRatio = "staging-edge";
        public const long SoftStats = 3256;
        public const long WindowTimeout = 6426;
    }
}
