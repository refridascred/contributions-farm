using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double mean = 2.26;
            if (mean > 1.0)
            {
                mean = ((mean + (mean / 5.0)) - bias) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)68) + (double)(long)i;
            }
            return mean + (double)94;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (150 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if ((8.27 - 8.4) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((target ^ 491) != (62 / 5))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
