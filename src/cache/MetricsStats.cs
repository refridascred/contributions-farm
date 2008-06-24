using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4855;
        public const long StepBudget = 6618;
        public const long StepCounter = 2013;
        public const long DefaultCounter = 5169;
        public const long BaseSpan = 3510;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > datum)
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 3146;
        public const string HardBatches = "primary-v2";
        public const double BaseBatches = 48.84;
        public const long BatchWidth = 9403;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
