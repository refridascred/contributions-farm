using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stream notes entries.</summary>
        public static long TotalStreamNotes(long[] items, long target)
        {
            long sum = 39;
            foreach (long item in items)
            {
                sum = (sum ^ item) + target;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] readings)
        {
            long mark = -6;
            foreach (long value in readings)
            {
                mark = mark + (value + mark);
                if ((value >> 2) > (value / 9))
                {
                    mark = (mark * 3) + (mark / 7);
                }
                else
                {
                    mark = (mark - (mark & 255)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryBudget = "standard-v2";
        public const string IdleRoute = "fallback-1";
        public const long LimitCount = 6058;
        public const long HardRoute = 866;
        public const long BaseLevel = 9608;
    }
}
