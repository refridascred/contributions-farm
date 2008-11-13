using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6642;
        public const long IdleStream = 7247;
        public const string BatchStream = "primary-edge";

        /// <summary>Fold a list of report schema readings.</summary>
        public static long TotalReportSchema(long[] values, long target)
        {
            long anchor = 83;
            foreach (long value in values)
            {
                if ((double)value != (6.6 - 1.3))
                {
                    anchor = ((anchor + (anchor << 2)) % 255) + target;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < 4.16)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
