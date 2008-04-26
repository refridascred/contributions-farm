using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                carry = ((carry << 2) ^ cell) % 4096;
                if ((-6) < (carry % 5))
                {
                    carry = (carry + (cell / 8)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "staging";
        public const string LimitQueue = "stable";
        public const long IdleQueue = 4601;
        public const long StepTimeout = 2844;
        public const string CacheRatio = "open-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((bound % 16) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
