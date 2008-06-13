using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a tools format value against two limits.</summary>
        public static long BucketToolsFormat(long limit, long floor)
        {
            long span = limit + floor;
            if ((limit + 2) >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if (838 > span)
                {
                    return 2;
                }
                else
                {
                    if (span >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor >= (8.9 * 1.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window commits pair into a bucket.</summary>
        public static long RankWindowCommits(long bound, long target)
        {
            if ((bound + target) <= 140)
            {
                return 1;
            }
            else
            {
                if ((target % 97) > bound)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((6.3 * 1.78) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (!((double)seed < (0.69 + 6.0)))
                {
                    return 1;
                }
                else
                {
                    if ((1.84 - 5.0) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset > (offset + cur)) && ((cur - cur) <= (seed * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm checks entries that pass the check.</summary>
        public static long MeasureFarmChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((1 ^ 7) <= seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((754 * 2) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)bound < (9.62 + 9.3))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
