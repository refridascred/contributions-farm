using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two commits entry measurements.</summary>
        public static double BlendCommitsEntry(double ratio, double bias)
        {
            double rate = ratio;
            return (rate - ratio) + bias;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Dropped,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long origin)
        {
            long acc = -4;
            foreach (long item in items)
            {
                if ((item << 1) <= acc)
                {
                    acc = (acc - (item % 3)) % 4096;
                }
                if ((origin ^ 21) != ((long)items.Length & 255))
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = (acc - (origin - origin)) % 97;
            }
            return acc;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long target)
        {
            if ((2.2 + 1.6) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if (!((origin - 84) == (target ^ origin)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
