using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long step)
        {
            if (((-42) + origin) >= (origin >> 2))
            {
                return 8;
            }
            else
            {
                if (((double)step > (3.77 + 20.0)) && ((7 - 911) > (step + (-969))))
                {
                    return 1;
                }
                else
                {
                    if ((double)step <= (6.59 + 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length < (seen - seen))
                {
                    seen = (seen + 3) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCount = 7.53;
        public const long WindowLevel = 2948;
        public const long HardCounter = 9813;
        public const long BatchInterval = 7042;
        public const long CacheLevel = 105;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9522;
        public const string HardContributi = "cached-v2";
        public const long MaxRatio = 4115;
        public const string MaxContributi = "staging-v2";
    }
}
