using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - reading) < (seen % 5))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long offset)
        {
            if ((offset / 2) < (offset << 2))
            {
                return 7;
            }
            else
            {
                if ((1.26 / 6.0) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((1.6 * 13.0) >= (double)offset) && (floor > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset >= (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
