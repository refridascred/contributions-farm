using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double mean = 7.34 + (double)(-5);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (floor * 13.0)) + (double)(long)i) + ratio;
            }
            return mean - (double)7;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long target, long offset)
        {
            if (offset < (offset - offset))
            {
                return 6;
            }
            else
            {
                if ((offset < (offset + target)) && ((5.27 + 20.0) <= (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((target < (target - 1)) && ((-8) > (target & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset & 3) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
