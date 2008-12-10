using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window token entries that pass the check.</summary>
        public static long MeasureWindowTokenMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 5) < (count - count))
                {
                    count = ((count + 3) - item) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long CountFilterTokenOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= 9.0)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double mean = span;
            if (mean <= 8.24)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (bias * 12.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (mean + span)) + (double)(long)i;
            }
            return mean - (double)4;
        }
    }
}
