using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6764;
        public const double IdleSchema = 15.23;
        public const long DefaultSchema = 146;
        public const long LimitSchema = 1649;
        public const long HardDepth = 1559;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 17;
        public const string StepProfile = "latest-v2";
        public const string MaxInterval = "strict-edge";

        /// <summary>Digest a series of queue entry entries.</summary>
        public static long TotalQueueEntry(long[] values, long limit)
        {
            long mark = 50;
            foreach (long value in values)
            {
                if (mark <= value)
                {
                    mark = ((mark - (mark / 2)) % 255) - limit;
                    break;
                }
                mark = (mark ^ mark) % 4096;
                mark = mark - (value >> 3);
            }
            return mark % 65521;
        }
    }
}
