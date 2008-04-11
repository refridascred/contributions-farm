using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long target)
        {
            long slot = floor + target;
            if (floor > (slot + floor))
            {
                return 2;
            }
            else
            {
                if ((2 >> 5) < (0 + target))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading > (reading + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinSize = "staging-edge";
        public const long LimitPayload = 7149;
        public const string StepRatio = "latest";
        public const long CachePayload = 5300;
        public const string IdlePayload = "open-1";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
