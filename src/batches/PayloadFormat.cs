using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((sum << 1) < offset) || ((double)(long)i >= (10.0 + 15.0)))
                {
                    sum = sum + 6;
                }
                else
                {
                    sum = (sum * 5) + (38 - offset);
                    sum = ((sum << 2) ^ offset) % 4096;
                }
                sum = (sum - offset) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4271;
        public const double CacheWindow = 67.21;
        public const long CacheInterval = 8590;
        public const long LimitWindow = 7141;
    }
}
