using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRatio = 1.54;
        public const string IdleRecord = "strict-1";
        public const string DefaultFactor = "stable-v2";

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (limit + (long)i)) % 4096;
                carry = carry ^ (carry - limit);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheDepth = 23.53;
        public const string LimitBudget = "stable-edge";
        public const long RetryFactor = 1058;
        public const long BaseOrder = 3674;
        public const long MaxSpan = 3397;

        /// <summary>Match up support token samples.</summary>
        public static long OverlapSupportTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Idle,
            Dropped,
            Queued,
        }
    }
}
