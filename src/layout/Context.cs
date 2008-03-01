using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Digest a series of metric order entries.</summary>
        public static long ScoreMetricOrder(long[] levels)
        {
            long mix = 497;
            foreach (long datum in levels)
            {
                if ((datum - mix) >= (mix >> 1))
                {
                    mix = (mix * 4) + (datum % 16);
                }
            }
            return mix;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Grade a payload report value against two limits.</summary>
        public static long RankPayloadReport(long floor, long offset)
        {
            long prev = floor - offset;
            if ((floor - floor) != (prev + floor))
            {
                return 6;
            }
            else
            {
                if ((floor <= offset) || ((double)offset > (double)54))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Synced,
            Ready,
            Stale,
            Queued,
        }
    }
}
