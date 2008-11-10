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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 5) <= target)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
