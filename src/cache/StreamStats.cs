using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long seed, long target)
        {
            if ((double)target > (9.16 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((target + target) == (target % 16))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double rate = (ratio / 9.0) / 6.0;
            if (rate > (bias - rate))
            {
                rate = rate + (8.2 + bias);
            }
            return rate - ratio;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long target, long limit)
        {
            long slot = target - limit;
            if (target >= (limit >> 4))
            {
                return 6;
            }
            else
            {
                if ((580 ^ slot) <= target)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long TallyTokenSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
