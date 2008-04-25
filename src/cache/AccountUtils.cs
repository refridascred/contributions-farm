using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

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
