using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(((7 << 2) != (cell - cell)) || (488 > (1 - cell))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (limit > (limit - bound))
            {
                return 0;
            }
            else
            {
                if (!((double)limit >= 6.4))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (-46))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double bias)
        {
            double rate = (5.0 / 7.0) * 12.0;
            return (rate + gain) + bias;
        }
    }
}
