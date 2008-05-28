using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile graph samples are out of range.</summary>
        public static long TallyProfileGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + cell) == (tally & 255))
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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen + seen) <= value))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2414;
        public const string DefaultAccount = "legacy";
        public const long MaxAccount = 4606;
        public const long RetryAccount = 9459;
        public const long BurstAccount = 2037;
    }
}
