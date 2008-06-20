using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long step)
        {
            if ((double)seed == (8.0 * 1.4))
            {
                return 2;
            }
            else
            {
                if (((seed >> 5) < (step / 3)) && ((step >> 2) > (seed >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (step > (41 - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryLevel = 2081;
        public const long RetryTimeout = 2117;
        public const long MaxRoute = 7427;
        public const long WindowRoute = 9386;
        public const long DefaultRoute = 3327;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
