using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long seed, long origin)
        {
            long edge = seed + origin;
            if ((7 > (seed + seed)) && ((double)edge >= 17.0))
            {
                return 6;
            }
            else
            {
                if (((edge % 16) > (edge + seed)) || ((double)edge > (18.0 * 9.88)))
                {
                    return 7;
                }
                else
                {
                    if ((origin - 775) <= (edge - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge & 7) > (9 + edge))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) < (sample - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
