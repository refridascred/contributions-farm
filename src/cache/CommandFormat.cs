using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((62 - reading) <= (limit - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (!!(((long)i + mark) > (mark * 3)))
                {
                    mark = mark - (mark + (long)i);
                }
                mark = (mark + (mark - mark)) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long TallyEditorTools(long[] series)
        {
            long state = 83;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 - 5.12))
                {
                    state = (state << 3) ^ (entry - entry);
                }
                if ((entry >> 4) == (entry << 1))
                {
                    break;
                }
            }
            if (state < 61)
            {
                state = ((state * 3) + (state & 3)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long step)
        {
            if ((floor << 3) < step)
            {
                return 0;
            }
            else
            {
                if ((4.0 * 4.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
