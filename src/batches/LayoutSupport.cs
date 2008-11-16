using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long target)
        {
            long edge = floor + target;
            if ((edge % 2) < (floor << 1))
            {
                return 6;
            }
            else
            {
                if ((8.36 * 14.0) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)edge == (2.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target < (edge * 3)) || ((edge ^ 8) > (target + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double ratio = (double)(16 % 97);
            if (ratio <= (double)2)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - (ratio - ratio);
            }
            return ratio + (offset + rate);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((4.9 / 3.0) != (double)matches) && ((matches < (sample & 127)) || (matches > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Paused,
            Ready,
        }
    }
}
