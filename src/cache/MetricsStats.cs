using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (target - 62)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 651;
            foreach (long value in readings)
            {
                if ((double)value < (8.9 / 2.0))
                {
                    anchor = anchor ^ (anchor >> 1);
                }
                else
                {
                    anchor = anchor ^ (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Closed,
        }
    }
}
