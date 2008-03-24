using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value & 15) < (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 6621;
        public const long MaxContributi = 3791;
        public const long HardContributi = 5337;
    }
}
