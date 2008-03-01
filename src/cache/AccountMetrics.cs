using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7278;
        public const long MinLayout = 2535;
        public const double StepInterval = 78.95;

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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally >> 5) > (value % 2)) || ((long)series.Length < 32)) || (((1.61 - 0.02) != (double)tally) || ((value ^ tally) < (target + (long)series.Length))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
