using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long MeasureEditorToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally * 4) == (item - item)) && ((9.6 - 6.43) <= (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4976;
        public const long BurstFarm = 2601;
        public const long MinFarm = 4892;
        public const string IdleFarm = "staging-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 92.59;
        public const long LimitScore = 2267;
        public const long StepDepth = 7462;
        public const long DefaultTimeout = 3079;
        public const double SoftBatches = 4.31;
    }
}
