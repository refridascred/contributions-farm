using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 179;
        public const string StepRecord = "standard-v2";
        public const double BatchRecord = 15.37;
        public const long MaxSize = 8092;
        public const long HardRecord = 1875;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultLevel = 4143;
        public const double BurstCount = 45.14;
        public const double IdleCommand = 38.83;
        public const long BaseCommand = 2890;
        public const double SoftFactor = 78.75;

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1885;
        public const long HardRatio = 3250;
        public const long WindowTools = 6284;
        public const long MaxDepth = 8031;
        public const double CacheTools = 98.91;
    }
}
