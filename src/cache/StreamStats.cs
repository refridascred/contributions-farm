using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Roll a entry route counter forward.</summary>
        public static long RollEntryRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((702 + sum) >= limit)
                {
                    sum = ((sum * 3) + ((long)i + (long)i)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank commits metrics input into a small class.</summary>
        public static long BucketCommitsMetrics(long bound, long seed)
        {
            long delta = bound - seed;
            if (!((bound % 100) <= (seed / 6)))
            {
                return 4;
            }
            else
            {
                if ((delta ^ 48) > 74)
                {
                    return 1;
                }
                else
                {
                    if (!((double)delta == (7.62 * 6.66)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)bound <= (0.8 * 7.72)) && ((6 ^ delta) < 252))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
