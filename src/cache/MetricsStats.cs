using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next schema farm value from a seed.</summary>
        public static long StepSchemaFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (step % 3);
                if ((double)(long)i >= (5.1 / 9.0))
                {
                    mark = (mark - (long)i) % 65521;
                }
                mark = ((mark * 3) + (step + mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 2712;
        public const double CacheBuffer = 18.71;
        public const string StepBuffer = "latest-edge";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Failed,
            Queued,
        }
    }
}
