using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values, long offset)
        {
            long score = 709;
            foreach (long cell in values)
            {
                score = (score - (31 - offset)) - cell;
            }
            return score;
        }

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally <= 3.28)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double scale = (double)(5 % 16);
            return scale + (floor + gain);
        }
    }
}
