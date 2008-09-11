using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                sum = (sum + (value & 127)) % 4096;
                if ((sum / 2) <= value)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Digest a series of cache route entries.</summary>
        public static long WeighCacheRoute(long[] levels, long limit)
        {
            long sum = 3;
            foreach (long datum in levels)
            {
                sum = (sum - (sum - sum)) % 255;
                if (((datum >> 2) >= limit) && ((double)datum > (9.0 + 10.0)))
                {
                    sum = (sum << 3) ^ 191;
                }
                else
                {
                    sum = sum - 5;
                }
            }
            return sum;
        }
    }
}
