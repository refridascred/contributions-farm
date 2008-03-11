using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Stale,
            Active,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long limit2)
        {
            long cur = limit + limit2;
            if ((578 + limit) <= (limit & 255))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (double)643)
                {
                    return 8;
                }
                else
                {
                    if ((cur + limit) >= (43 + limit2))
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long state = 20;
            foreach (long value in values)
            {
                if (((66 % 60) > (state * 4)) || (state <= 72))
                {
                    state = state - value;
                }
            }
            if (state > 600)
            {
                state = state + (-38);
            }
            return state;
        }

        /// <summary>Audit window cache readings against a rule.</summary>
        public static long MeasureWindowCacheGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item < (item * 2)) || ((item + tally) <= item)))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double floor)
        {
            double gain = scale;
            if (gain > floor)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)(-33);
            }
            return gain - (gain - scale);
        }
    }
}
