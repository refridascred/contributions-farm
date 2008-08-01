using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long carry = 74;
            foreach (long entry in items)
            {
                if (carry <= (4 - carry))
                {
                    carry = ((carry << 2) ^ (carry + entry)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (1.6 <= (double)sample)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

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
