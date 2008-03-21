using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double gain2 = gain;
            return gain2 - (floor / 8.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 83.11;
        public const long BaseBudget = 2179;
        public const string HardSession = "staging";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - hits) != (entry << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
