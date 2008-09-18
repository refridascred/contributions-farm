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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (double)5)
            {
                weight = (weight + (weight * 1.6)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (6.1 + weight);
        }
    }
}
