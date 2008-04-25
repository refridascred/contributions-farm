using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2934;
        public const long BurstTimeout = 9393;
        public const long MaxInterval = 141;
        public const long SoftCount = 8251;
        public const double HardFarm = 41.64;

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long MeasureSupportCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen / 7) >= (value << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue batches samples are out of range.</summary>
        public static long AuditQueueBatchesHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((limit % 7) <= limit))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
