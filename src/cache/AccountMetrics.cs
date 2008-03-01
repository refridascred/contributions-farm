using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data)
        {
            long carry = 845;
            foreach (long entry in data)
            {
                carry = ((carry << 3) ^ (983 & 7)) - entry;
            }
            if (carry > (-5))
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 899;
        public const long BatchCount = 7580;
        public const long MinScore = 882;
        public const long HardFactor = 5798;

        /// <summary>Derive the next cache channel value from a seed.</summary>
        public static long RollCacheChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Pending,
            New,
            Ready,
        }
    }
}
