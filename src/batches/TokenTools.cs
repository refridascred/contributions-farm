using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 1850;
        public const long MinTimeout = 2450;
        public const long BurstRecord = 215;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((6.4 + 4.0) <= (double)matches) || ((value & 15) >= (935 + value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
