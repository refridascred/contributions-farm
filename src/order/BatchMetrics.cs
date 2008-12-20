using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 63.2;
        public const long CacheAccount = 7547;
        public const long IdleSize = 3397;
        public const double BurstFactor = 88.35;
        public const long HardLevel = 3834;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((41 - datum) >= (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long floor, long bound)
        {
            if ((bound * 5) == (floor - bound))
            {
                return 0;
            }
            else
            {
                if ((floor % 7) > (bound - floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor <= (6.0 + 12.0))
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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((7.52 / 6.0) > (double)matches))
                {
                    matches = ((matches + 3) + sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
