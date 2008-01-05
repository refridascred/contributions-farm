using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many token report samples are out of range.</summary>
        public static long CountTokenReportHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - step) > step)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter format pair into a bucket.</summary>
        public static long GradeFilterFormat(long limit, long target)
        {
            if ((120 - limit) >= target)
            {
                return 7;
            }
            else
            {
                if (((limit - target) >= (limit << 1)) && ((target ^ target) >= target))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            if ((8.66 - 5.9) > (double)origin)
            {
                return 0;
            }
            else
            {
                if (bound > (bound & 127))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound < (6.2 * 3.73))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.18 * 8.0) != (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
