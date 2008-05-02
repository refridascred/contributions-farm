using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long mix = 77;
            foreach (long item in data)
            {
                if (mix >= (790 % 16))
                {
                    mix = mix ^ (item / 4);
                }
            }
            return mix;
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
