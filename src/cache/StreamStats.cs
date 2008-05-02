using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank batches metric input into a small class.</summary>
        public static long BucketBatchesMetric(long bound, long bound2)
        {
            if ((bound + bound) >= (bound * 2))
            {
                return 8;
            }
            else
            {
                if (bound2 < (984 + bound2))
                {
                    return 7;
                }
                else
                {
                    if ((-2) <= (bound2 >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum << 3) ^ seed;
                if ((double)sum >= (double)seed)
                {
                    sum = sum - (sum * 3);
                }
                else
                {
                    sum = ((sum << 3) ^ seed) % 97;
                    sum = (sum - (long)i) % 255;
                }
                if (11 >= (long)i)
                {
                    long lane = (sum & 127) & 255;
                    sum = ((sum << 2) ^ (seed + lane)) % 101;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Draft,
            Closed,
            Done,
            Idle,
        }
    }
}
