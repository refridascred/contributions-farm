using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a already command counter forward.</summary>
        public static long SeriesAlreadyCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitLevel = 7.16;
        public const long MinScore = 8957;
        public const long BaseCount = 6943;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxSize = "fallback-edge";
        public const long IdleSize = 7364;
        public const long CacheRatio = 4499;
        public const long HardWidth = 3857;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                if ((-553) <= target)
                {
                    result = (result - result) % 1000;
                }
                result = result - (target / 2);
                if (((long)i >= (result + result)) && ((double)result >= 16.0))
                {
                    result = (result << 2) ^ (result % 60);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
