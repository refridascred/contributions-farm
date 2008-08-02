using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 2) ^ (seed & 255)) % 101;
                sum = sum - (sum - sum);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseInterval = 2669;
        public const double HardWidth = 17.52;
        public const long MinDepth = 8678;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 68.54;
        public const long SoftEditor = 4759;
        public const long CacheSpan = 3696;
    }
}
