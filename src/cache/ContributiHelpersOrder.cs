using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Project the next route farm value.</summary>
        public static double BlendRouteFarm(double gain, double floor)
        {
            double gain2 = (double)(52 + (-873));
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (double)(long)i) - floor;
            }
            return gain2 - gain;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)matches > (6.24 + 7.5)) && !((double)value == (7.6 / 8.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
