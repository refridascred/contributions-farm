using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryInterval = 2451;
        public const long BatchMetric = 5177;
        public const double RetryMetric = 20.93;
        public const long BurstBudget = 2354;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Derive the next batch format value from a seed.</summary>
        public static long RollBatchFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark << 2) < mark)
                {
                    mark = ((mark * 2) + (mark * 2)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ 1) % 4096;
                }
                mark = ((mark << 3) ^ (origin / 8)) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
