using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > (matches + 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultFactor = 4498;
        public const long DefaultScore = 8590;
        public const long SoftWidth = 1048;
        public const string RetryRatio = "open-1";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((980 + 67) != (sample * 5)) && ((2.8 / 4.0) == (double)sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
