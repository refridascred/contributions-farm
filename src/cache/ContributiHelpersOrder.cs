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

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double scale = (double)(5 % 16);
            return scale + (floor + gain);
        }
    }
}
