using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 25.29;
        public const double BurstBudget = 72.26;
        public const double BaseDepth = 1.99;
        public const string HardFactor = "open";

        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long MeasureAccountEditorGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((double)step < (double)2) || ((79 + step) == ((-149) * 3)))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
