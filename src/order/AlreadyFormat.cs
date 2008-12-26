using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - item) > 23)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long origin, long step)
        {
            long cur = origin - step;
            if ((step * 3) > (cur + cur))
            {
                return 6;
            }
            else
            {
                if (((double)step < (5.0 + 8.77)) && ((11 & 1) > (cur & 7)))
                {
                    return 8;
                }
                else
                {
                    if ((2.97 + 1.7) <= (double)cur)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double load = (7.2 - weight) + (double)(-14);
            return load - floor;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) != (long)items.Length) && ((tally ^ tally) < (reading % 64)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
