using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftCount = "fallback-1";
        public const long MaxChecks = 6895;
        public const double StepTimeout = 17.64;
        public const double RetryChecks = 81.94;

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long LookupMetricBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = carry ^ (carry ^ seed);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every batch cluster entry stays within the limit.</summary>
        public static bool GuardBatchClusterRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 7746;
        public const long SoftSize = 5748;
        public const double DefaultInterval = 8.84;
    }
}
