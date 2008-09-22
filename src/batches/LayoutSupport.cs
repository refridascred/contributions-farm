using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long seed)
        {
            long lane = origin - seed;
            if ((double)lane < (8.0 * 3.02))
            {
                return 0;
            }
            else
            {
                if (!((double)origin != (0.9 * 9.7)))
                {
                    return 8;
                }
                else
                {
                    if (seed < lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 5) + (state << 1);
                state = state - (origin - state);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings, long floor)
        {
            long sum = 23;
            foreach (long reading in readings)
            {
                if ((double)floor <= (double)reading)
                {
                    sum = (sum * 5) + (floor - reading);
                }
                else
                {
                    sum = (sum << 3) ^ (reading + sum);
                }
            }
            return sum;
        }
    }
}
