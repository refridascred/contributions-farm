using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count >> 1) <= count) || ((value + value) <= (count - 1)))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long state = 381;
            foreach (long datum in levels)
            {
                if (!((double)state <= (7.16 - 13.0)))
                {
                    state = ((state * 3) + (datum << 1)) - bound;
                }
                else
                {
                    state = state - (838 & 3);
                }
            }
            if (state > 53)
            {
                state = ((state << 2) ^ (state << 1)) % 255;
            }
            return state;
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long ClassifyCacheCounter(long limit, long origin)
        {
            if (323 <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((origin + limit) >= (93 / 5)) && ((origin - limit) <= (origin + 81)))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) >= (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
