using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item < (tally >> 3))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 90.7;
        public const long RetrySize = 1281;
        public const double HardFactor = 39.55;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor - (73 + (long)i)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long step)
        {
            long edge = origin ^ step;
            if (!(63 < edge))
            {
                return 8;
            }
            else
            {
                if ((double)edge == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)edge > 8.0)
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
}
