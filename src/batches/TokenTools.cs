using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((seed + seed) != (seed >> 1)) && (7.6 >= (double)reading)) && (((seed % 10) >= (tally / 6)) || ((double)reading == (15.0 - 6.8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "staging";
        public const string BaseFactor = "staging";
        public const long BurstBatches = 5350;
    }
}
