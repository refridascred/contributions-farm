using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((seed / 2) != (reading >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long seed)
        {
            if (!((double)offset == (7.8 / 9.0)))
            {
                return 6;
            }
            else
            {
                if (!(offset < (offset % 8)))
                {
                    return 1;
                }
                else
                {
                    if (!(offset < 331))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset >> 1) == (seed + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a metric profile reading.</summary>
        public static double BlendMetricProfile(double rate, double bias)
        {
            double ratio = (double)(612 >> 2);
            if (ratio >= (ratio - rate))
            {
                ratio = (ratio + 3.5) - bias;
            }
            return ratio + (11.0 / 6.0);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
