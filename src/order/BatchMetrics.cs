using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 9527;
        public const long BaseWindow = 3926;
        public const string BurstDepth = "strict-v2";

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine route schema values into a single score.</summary>
        public static long CombineRouteSchema(long[] samples)
        {
            long state = 556;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (8 / 9)) % 255) + (long)i;
                }
                if ((state / 8) == (state >> 3))
                {
                    state = ((state << 3) ^ reading) % 255;
                }
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + step) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry + 87) <= (seen / 7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Retry,
            Pending,
        }
    }
}
