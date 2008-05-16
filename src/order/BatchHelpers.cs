using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5773;
        public const double MinBudget = 0.42;
        public const long BurstScore = 3234;
        public const double BatchAlready = 49.48;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target + count) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
