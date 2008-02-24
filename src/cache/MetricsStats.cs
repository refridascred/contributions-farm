using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((4.13 * 0.27) == (double)matches)
                {
                    matches = ((matches + 3) ^ reading) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstDepth = 79.96;
        public const string MaxInterval = "stable-v2";
        public const double DefaultRoute = 93.95;
        public const long IdleRoute = 9508;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryWidth = 54.09;
        public const long BurstTimeout = 8228;
        public const string StepLevel = "alpha-edge";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((407 < (offset + floor)) && (bound < (31 & 1)))
            {
                return 8;
            }
            else
            {
                if ((offset << 3) != (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 4) != (floor / 3)) || ((double)floor < 4.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - bound) != (bound + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
