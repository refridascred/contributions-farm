using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            if (((double)588 >= (double)target) || (limit < (target - limit)))
            {
                return 7;
            }
            else
            {
                if ((8.77 + 9.0) == (double)target)
                {
                    return 8;
                }
                else
                {
                    if (!((10 % 8) < target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits <= (item / 8))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 3042;
        public const double StepCount = 88.63;
        public const long LimitCount = 4047;
        public const long BurstFactor = 6532;
        public const long MinContext = 4798;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 7198;
        public const long MaxInterval = 3878;
        public const long BaseDepth = 5483;
        public const string MinScore = "standard";
        public const long LimitInterval = 8065;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((0 + offset) != (offset * 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
