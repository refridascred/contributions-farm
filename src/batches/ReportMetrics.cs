using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank record commits input into a small class.</summary>
        public static long BucketRecordCommits(long seed, long target)
        {
            long prev = seed - target;
            if ((target - target) <= 29)
            {
                return 7;
            }
            else
            {
                if (seed < (prev / 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed + prev) > (prev >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 < target) || (seed > target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseDepth = 529;
        public const long LimitInterval = 7888;
        public const long StepChecks = 6185;
        public const double CacheSpan = 34.26;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (scale * 4.5))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (weight * 7.65);
        }
    }
}
