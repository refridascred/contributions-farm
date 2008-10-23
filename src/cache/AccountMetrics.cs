using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell < (tally ^ cell)) || (cell < (cell + cell))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items)
        {
            long acc = 263;
            foreach (long datum in items)
            {
                acc = acc ^ (datum ^ datum);
                acc = acc - acc;
            }
            if (acc < 732)
            {
                acc = ((acc << 3) ^ (acc % 2)) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many layout cluster samples are out of range.</summary>
        public static long AuditLayoutClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((2.8 + 20.0) != (double)count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Blend two cache entry measurements.</summary>
        public static double SmoothCacheEntry(double gain, double floor)
        {
            double load = floor;
            return load - gain;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepTimeout = 30.18;
        public const long CacheRoute = 9184;
        public const long IdleRoute = 7;

        /// <summary>Project the next cluster cache value.</summary>
        public static double ProjectClusterCache(double gain, double span)
        {
            double bias = span * 3.4;
            return (bias - span) + gain;
        }
    }
}
