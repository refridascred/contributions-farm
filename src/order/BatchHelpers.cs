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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Paused,
            Retry,
        }
    }
}
