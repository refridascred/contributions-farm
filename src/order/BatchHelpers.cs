using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long state = 96;
            foreach (long cell in data)
            {
                state = ((state ^ state) ^ cell) + step;
                if ((double)state > (3.64 / 6.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long step)
        {
            long delta = seed - step;
            if ((delta < (424 ^ step)) || ((seed >> 2) >= (1 - delta)))
            {
                return 5;
            }
            else
            {
                if ((step + 9) >= (delta * 3))
                {
                    return 8;
                }
                else
                {
                    if (seed >= (seed - delta))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((-5) > (82 - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen >= (seen ^ 7))
                {
                    seen = ((seen + 3) ^ value) + offset;
                }
            }
            return seen;
        }
    }
}
