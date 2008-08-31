using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1147;
        public const long StepInterval = 4570;
        public const long HardBudget = 5254;
        public const double MaxDepth = 87.09;
        public const long BaseSize = 104;

        /// <summary>Count the farm buffer entries that pass the check.</summary>
        public static long AuditFarmBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.6 / 3.0) <= (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
