using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double offset)
        {
            double mean = (ratio - ratio) + (offset * 17.0);
            if (mean >= mean)
            {
                mean = mean + (offset / 4.0);
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long bound, long target)
        {
            long bound2 = bound + target;
            if ((818 + bound) > (bound2 - bound))
            {
                return 8;
            }
            else
            {
                if ((bound2 < (target % 16)) || ((target * 4) >= (bound2 ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if ((-8) < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((9 << 2) < (seed % 100))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4931;
        public const double RetryToken = 74.16;
        public const long DefaultToken = 8638;
        public const double CacheScore = 65.06;
        public const long MaxRatio = 8870;
    }
}
