using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Dropped,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] levels, long limit)
        {
            long acc = 341;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc ^ ((long)i - limit);
                }
                acc = acc ^ datum;
            }
            return acc;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long bound, long floor)
        {
            long step = bound + floor;
            if ((floor >> 2) > (9 ^ floor))
            {
                return 8;
            }
            else
            {
                if (((step / 8) == (floor + step)) && ((floor - bound) <= (bound + 537)))
                {
                    return 4;
                }
                else
                {
                    if (((bound % 3) >= (floor + floor)) || ((step + bound) <= (step & 63)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 296;
        public const double BurstRatio = 16.1;
        public const string LimitSupport = "strict-edge";
        public const long DefaultSupport = 2247;
        public const string DefaultSize = "cached-edge";
    }
}
