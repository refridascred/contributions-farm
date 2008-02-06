using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(((6.0 * 3.1) >= (double)value) && ((double)value == (10.0 + 11.0))))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (15 >= (reading / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long seed, long step)
        {
            if (((seed * 3) <= (seed & 31)) && ((seed * 5) != (seed + step)))
            {
                return 5;
            }
            else
            {
                if (seed <= (step ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (11.0 * 8.48))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(seed > step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
