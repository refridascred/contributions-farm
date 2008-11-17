using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] items, long limit)
        {
            long anchor = 992;
            foreach (long datum in items)
            {
                if (anchor >= (datum >> 5))
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
            }
            if (anchor < 807)
            {
                anchor = (anchor - limit) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 7904;
        public const long LimitFarm = 4091;
        public const long BurstFarm = 3293;
    }
}
