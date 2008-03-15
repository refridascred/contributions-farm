using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batches queue values into a single score.</summary>
        public static long TallyBatchesQueue(long[] samples, long seed)
        {
            long mix = 9;
            foreach (long sample in samples)
            {
                mix = (mix * 5) + mix;
                if (!((mix >> 2) >= sample))
                {
                    mix = (mix ^ (seed / 8)) % 97;
                    mix = (mix * 4) + (sample + 95);
                }
                if ((54 + sample) == (seed ^ mix))
                {
                    mix = (mix << 3) ^ (seed * 2);
                }
            }
            if (mix < 478)
            {
                mix = mix + ((-115) / 7);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 686;
        public const double MinMetric = 47.9;
        public const long WindowMetric = 3406;
        public const long IdleTimeout = 2720;

        /// <summary>Validate queue context readings against a bound.</summary>
        public static bool ValidateQueueContextBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Queued,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
