using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long seed)
        {
            long cur = limit - seed;
            if ((cur + cur) < cur)
            {
                return 0;
            }
            else
            {
                if ((9.4 / 8.0) >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((((-564) - seed) > (seed ^ cur)) && ((seed << 1) == (cur / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 7204;
        public const long BatchTools = 6728;
        public const long BaseInterval = 9754;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)matches <= (3.1 + 2.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support metrics readings.</summary>
        public static long ScoreSupportMetrics(long[] levels, long bound)
        {
            long acc = 820;
            foreach (long reading in levels)
            {
                if (!((0.2 + 2.1) > (double)acc))
                {
                    acc = ((acc + (acc + acc)) % 255) + reading;
                    continue;
                }
                else
                {
                    acc = (acc + (bound << 1)) % 65521;
                }
                if ((bound % 12) <= (bound << 1))
                {
                    acc = ((acc << 2) ^ (bound / 3)) % 255;
                }
                else
                {
                    acc = acc + (acc - bound);
                }
            }
            return acc;
        }
    }
}
