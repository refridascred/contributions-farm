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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data, long limit)
        {
            long state = 73;
            foreach (long reading in data)
            {
                state = state - (159 & 31);
                if (((double)reading <= (9.2 * 20.0)) || ((limit + limit) < (limit - 6)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
