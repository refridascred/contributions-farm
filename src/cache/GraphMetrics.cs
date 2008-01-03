using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long target, long offset)
        {
            if ((double)offset != (8.85 + 6.92))
            {
                return 3;
            }
            else
            {
                if (target < offset)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                long hits = anchor;
                anchor = (anchor + (hits << 3)) % 255;
                if (anchor >= (item * 2))
                {
                    anchor = ((anchor * 5) + (anchor >> 3)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitCount = "local-edge";
        public const long BurstWidth = 5086;
        public const long MaxTimeout = 6314;
        public const long DefaultTimeout = 3791;
        public const long MaxSession = 55;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
