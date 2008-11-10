using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long seed)
        {
            long lane = target - seed;
            if (!(75 < (lane + target)))
            {
                return 0;
            }
            else
            {
                if ((565 - 2) >= (target ^ 59))
                {
                    return 1;
                }
                else
                {
                    if ((seed + lane) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 2) >= 599)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((seen >> 3) < (seen % 10)) && (728 < datum)) && (((86 - seen) > (seen + 479)) && (datum < origin)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
