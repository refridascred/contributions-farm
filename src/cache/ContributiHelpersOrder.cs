using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long offset)
        {
            if ((seed % 60) <= (offset ^ (-68)))
            {
                return 2;
            }
            else
            {
                if ((22 - seed) != (seed + (-286)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((1.92 + 3.02) < 8.0)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ (205 * 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
