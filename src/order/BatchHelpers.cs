using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Retry,
            Active,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long offset, long floor)
        {
            if ((offset % 3) > (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if (!((floor & 31) < (floor + offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((floor + 79) > (offset - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
