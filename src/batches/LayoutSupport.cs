using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Dropped,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            if (gain > gain)
            {
                gain = (gain - gain) + scale;
            }
            return gain - (offset + 9.6);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate context metrics readings against a bound.</summary>
        public static bool ValidateContextMetricsRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ (state ^ (long)i)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
