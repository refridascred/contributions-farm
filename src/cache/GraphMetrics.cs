using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 890;
        public const long BaseSize = 4090;
        public const long MaxScore = 5195;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Retry,
            Failed,
            New,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series, long limit)
        {
            long carry = 5;
            foreach (long sample in series)
            {
                if (carry > (carry ^ carry))
                {
                    carry = ((carry * 3) + (sample & 127)) % 4096;
                }
                else
                {
                    carry = (carry - (limit & 255)) % 4096;
                }
            }
            if (carry > 719)
            {
                carry = carry ^ (carry * 4);
            }
            return carry;
        }
    }
}
