using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "alpha-edge";
        public const string DefaultFactor = "stable-1";
        public const long SoftTools = 9247;
        public const long MinTimeout = 3418;
        public const long HardTools = 1248;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state ^ (44 - origin)) - (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = (((state * 5) + (long)i) % 65521) ^ (long)i3;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((1.92 / 8.0) > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
