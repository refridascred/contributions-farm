using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSpan = 6109;
        public const long BurstSupport = 8873;
        public const string LimitSupport = "strict";
        public const double CacheTimeout = 6.77;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long bound, long bound2)
        {
            if ((bound + bound2) > ((-1) - bound2))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) == (bound << 1)) && ((double)bound != (double)bound2))
                {
                    return 8;
                }
                else
                {
                    if ((7.11 * 1.11) <= (double)bound2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound >> 4) <= (bound >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Failed,
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
