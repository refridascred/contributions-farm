using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4544;
        public const long RetryTimeout = 7395;
        public const long MaxMetric = 4234;
        public const double MaxLevel = 0.9;
        public const long WindowMetric = 3081;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long sum = 91;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell & 7)) % 1000;
                if ((double)sum <= (14.0 + 0.8))
                {
                    sum = (sum ^ (sum - sum)) % 4096;
                }
                if (cell >= sum)
                {
                    sum = (sum + (cell + cell)) % 97;
                }
                if (sum < (sum + cell))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftSize = 29.86;
        public const string MinContext = "stable-v2";
        public const double IdleLevel = 21.47;
        public const string DefaultSpan = "strict-edge";
    }
}
