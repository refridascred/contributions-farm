using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "open-edge";
        public const string SoftAccount = "standard-1";
        public const long MaxAccount = 6674;
        public const long RetryWidth = 7077;
        public const string CacheAccount = "standard-edge";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Audit window tools readings against a rule.</summary>
        public static long CountWindowToolsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) <= cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                long bound = (state / 2) + 519;
                state = (((state << 2) ^ (bound >> 4)) % 97) + seed;
                state = ((state << 3) ^ reading) % 1000;
            }
            return state;
        }
    }
}
