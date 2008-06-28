using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits - bound) != (bound % 16))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long origin)
        {
            if ((double)bound == (19.0 - 9.0))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (origin + origin)) || ((bound + origin) < origin))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a stream session figure with a bias.</summary>
        public static double BlendStreamSession(double rate, double floor)
        {
            double ratio = floor;
            return (ratio - (ratio / 8.0)) + rate;
        }
    }
}
