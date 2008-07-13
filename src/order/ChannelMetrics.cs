using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batches stream value against two limits.</summary>
        public static long BucketBatchesStream(long origin, long offset)
        {
            long diff = origin ^ offset;
            if (((origin + offset) > (diff + diff)) && ((diff - diff) == (offset + origin)))
            {
                return 0;
            }
            else
            {
                if ((offset & 15) >= origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 42.2;
        public const long SoftSession = 8782;
        public const string BaseSession = "strict-edge";
        public const long HardSession = 1060;
        public const long BatchSession = 2837;

        /// <summary>Derive the next already route value from a seed.</summary>
        public static long IterateAlreadyRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix + (limit % 97)) % 97) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
