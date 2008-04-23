using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long floor, long floor2)
        {
            if (25 <= (floor2 >> 3))
            {
                return 7;
            }
            else
            {
                if ((977 - floor2) <= (floor2 + floor2))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < 6.06)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long target)
        {
            long delta = offset + target;
            if ((offset ^ target) > (target * 4))
            {
                return 5;
            }
            else
            {
                if ((delta + delta) <= delta)
                {
                    return 2;
                }
                else
                {
                    if (((7.04 + 2.22) != (double)offset) && ((double)delta != (double)offset))
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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound < (bound - floor))
            {
                return 2;
            }
            else
            {
                if (1 >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (((3.9 / 3.0) > (double)bound) && (bound > (floor - 619)))
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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = state + (floor + floor);
                state = (state ^ (floor - floor)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) <= (0 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
