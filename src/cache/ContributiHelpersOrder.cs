using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 88.1;
        public const long SoftCommits = 1304;
        public const double SoftBudget = 60.51;
        public const long BurstLevel = 3970;
        public const long MinDepth = 7376;

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double gain = span;
            return gain + (rate * 4.9);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (double)649)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
