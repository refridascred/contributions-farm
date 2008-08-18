using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally >= (double)41)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxLevel = 6219;
        public const double BatchNotes = 12.74;
        public const string BatchRatio = "legacy-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 509;
        public const long HardInterval = 6358;
        public const long BurstTimeout = 985;
        public const double MinDepth = 19.14;
    }
}
