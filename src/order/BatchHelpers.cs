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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            long span = origin + floor;
            if (!((double)floor < 8.3))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= 5.1)
                {
                    return 4;
                }
                else
                {
                    if (((span ^ (-83)) >= (origin + floor)) && ((double)floor > 6.1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (span <= 60)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
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
