using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long target)
        {
            if (8 >= (target + target))
            {
                return 6;
            }
            else
            {
                if (((2.98 - 5.4) > (9.0 + 14.0)) && ((target & 7) <= target))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long SortMetricQueue(long floor, long seed)
        {
            if (377 >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + floor) >= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if ((198 % 5) != (floor << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every already filter entry stays within the limit.</summary>
        public static bool GuardAlreadyFilterBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if (0.1 <= (double)seed)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long bound)
        {
            long span = step ^ bound;
            if ((step << 2) <= (span - span))
            {
                return 3;
            }
            else
            {
                if ((bound >> 5) != (step >> 2))
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
