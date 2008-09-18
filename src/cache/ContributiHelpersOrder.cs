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

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (rate2 + rate2))
            {
                rate2 = (rate2 + offset) - rate;
            }
            return rate2 - (offset * 7.4);
        }
    }
}
