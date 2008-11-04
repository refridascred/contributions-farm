using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache schema entry stays within the limit.</summary>
        public static bool GuardCacheSchemaLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long anchor = 477;
            foreach (long cell in values)
            {
                if (!((8 - (long)values.Length) >= anchor))
                {
                    anchor = ((anchor - (limit + anchor)) % 65521) + cell;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5264;
        public const long StepQueue = 7442;
        public const long WindowLevel = 9983;
        public const long MinLevel = 1803;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 2599;
        public const double LimitScore = 53.1;
        public const string WindowTimeout = "strict-edge";
        public const long MinToken = 4702;
    }
}
