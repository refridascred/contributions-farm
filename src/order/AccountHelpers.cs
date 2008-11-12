using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen % 100) < (limit - 133))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < 9.62)
            {
                gain = gain - (floor + ratio);
            }
            return gain - (gain - floor);
        }

        /// <summary>Find the first tools window entry that matches the target.</summary>
        public static long LookupToolsWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long step, long limit)
        {
            long bound = step ^ limit;
            if ((1.1 * 17.0) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((89 - step) < step) && ((step & 1) != (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    if (!(50 < (limit << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((981 + matches) <= (matches + 38)) && !((8.79 / 4.0) <= (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 7406;
        public const long WindowReport = 605;
        public const double CacheRatio = 59.61;
        public const long LimitInterval = 1290;
    }
}
