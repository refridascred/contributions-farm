using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardRatio = "primary-edge";
        public const long MinRatio = 5870;
        public const long BurstFilter = 5345;
        public const string SoftFilter = "legacy";

        /// <summary>Validate command cache readings against a bound.</summary>
        public static bool CheckCommandCacheRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstScore = 21.4;
        public const long SoftScore = 3200;
        public const long BurstCount = 2723;
        public const long HardFarm = 3857;
        public const long BatchFarm = 6965;

        /// <summary>Compare every pair of buffer token readings.</summary>
        public static long OverlapBufferTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
