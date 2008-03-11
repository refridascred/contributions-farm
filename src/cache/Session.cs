using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long floor2)
        {
            if ((double)floor < (double)floor2)
            {
                return 4;
            }
            else
            {
                if ((floor2 & 63) != (floor2 + floor2))
                {
                    return 8;
                }
                else
                {
                    if (floor2 <= (41 ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a commits command reading by value.</summary>
        public static long SeekCommitsCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long floor)
        {
            long sum = 748;
            foreach (long item in items)
            {
                sum = (sum ^ (item + (-76))) - floor;
            }
            if (sum < 808)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }
    }
}
