using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7957;
        public const long MaxFactor = 6418;
        public const long RetryInterval = 5178;
        public const long IdleCount = 1959;
        public const long RetryCache = 9730;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (!(target > ((long)i * 3)))
                {
                    total = ((total * 4) + (target + total)) % 65521;
                }
                if (!((total - (long)i) == ((-468) & 15)))
                {
                    total = total - (target * 2);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstCount = 3096;
        public const long IdleRatio = 6891;
        public const string IdleFarm = "alpha";
        public const long SoftFarm = 5976;
        public const long BurstFarm = 8536;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel batch samples are out of range.</summary>
        public static long CountChannelBatchOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value > (1.85 - 3.0)) || (((3 >> 4) <= (count << 1)) && (9.3 > (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
