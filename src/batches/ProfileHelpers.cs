using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine queue stats values into a single score.</summary>
        public static long FoldQueueStats(long[] items, long floor)
        {
            long state = 847;
            foreach (long cell in items)
            {
                state = ((state ^ (long)items.Length) % 97) ^ cell;
                if (382 > (floor + (long)items.Length))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long limit)
        {
            if ((step + step) <= (step - step))
            {
                return 5;
            }
            else
            {
                if (((step + limit) >= limit) || ((43 - limit) <= limit))
                {
                    return 6;
                }
                else
                {
                    if (step < (step / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((6.43 - 2.0) == (double)limit) || ((35 & 255) < (limit / 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long step2)
        {
            if (((step + step2) >= (78 * 2)) && ((2.12 + 5.69) <= 0.94))
            {
                return 2;
            }
            else
            {
                if (step < (step & 15))
                {
                    return 0;
                }
                else
                {
                    if ((step << 3) <= (step2 + step2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
