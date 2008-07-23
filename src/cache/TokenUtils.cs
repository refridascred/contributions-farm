using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Failed,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3564;
        public const long HardBatch = 5055;
        public const string BurstBatch = "primary-edge";
        public const long MaxInterval = 9109;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (target < (reading & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
