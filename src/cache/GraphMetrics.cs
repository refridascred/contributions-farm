using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 3328;
        public const long DefaultScore = 4228;
        public const long HardWidth = 6293;
        public const long RetryRatio = 5327;
        public const string IdleQueue = "standard";

        /// <summary>Accumulate order token samples.</summary>
        public static long CombineOrderToken(long[] data, long floor)
        {
            long acc = 679;
            foreach (long value in data)
            {
                acc = ((acc - (acc / 4)) % 101) - value;
                if ((floor + 14) <= acc)
                {
                    acc = (acc * 2) + floor;
                }
                if (((double)acc >= 9.85) || (acc < (4 * 2)))
                {
                    break;
                }
            }
            if (acc < (-5))
            {
                acc = ((acc * 4) + (acc + floor)) % 1000;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((9.15 / 3.0) > (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultDepth = 2197;
        public const string BaseSchema = "latest";
        public const long MinSchema = 4351;
        public const long DefaultSchema = 7822;

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "fallback-edge";
        public const long StepFactor = 7486;
        public const long LimitPayload = 2755;
    }
}
