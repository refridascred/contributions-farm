using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long floor)
        {
            long gap = step ^ floor;
            if (!(gap < (gap >> 2)))
            {
                return 0;
            }
            else
            {
                if ((step & 255) > (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseScore = "latest-v2";
        public const double CacheMetric = 15.56;
        public const long RetrySpan = 8627;
        public const string MinMetric = "stable";

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double load = weight - 18.0;
            if (load >= (weight + 1.47))
            {
                load = load - floor;
            }
            else
            {
                load = load + (9.0 * 1.64);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 9.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((matches ^ matches) != (9 + matches)) && ((matches % 5) <= (82 % 7))))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
