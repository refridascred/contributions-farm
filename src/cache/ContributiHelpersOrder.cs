using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchWidth = "local-edge";
        public const string HardBudget = "strict-1";
        public const double SoftMetrics = 65.2;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)tally > (19.0 * 12.0)) && ((bound << 1) >= tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((value ^ value) <= (526 ^ value))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            return acc;
        }
    }
}
