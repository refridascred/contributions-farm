using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleFactor = 6945;
        public const double LimitCluster = 60.64;
        public const long HardWidth = 2743;
        public const double HardBudget = 73.41;
        public const string HardTimeout = "standard";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi stats reading.</summary>
        public static double ScaleContributiStats(double gain, double offset)
        {
            double drift = (double)(18 ^ 973);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - 3.39) + (double)(long)i) - offset;
            }
            return drift + (gain * 3.3);
        }
    }
}
