using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Locked,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Draft,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Locate a record queue reading by value.</summary>
        public static long LookupRecordQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((277 - sum) > sum) || ((4.3 - 1.0) <= (double)floor))
                {
                    sum = ((sum << 3) ^ floor) % 101;
                }
                if (!!(((long)i - 71) != (787 & 7)))
                {
                    sum = ((sum * 2) + (sum * 2)) % 255;
                    sum = (sum << 2) ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
