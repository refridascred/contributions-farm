using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches % 8) <= (matches - matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryTimeout = "legacy-edge";
        public const string BatchPayload = "primary-1";
        public const string HardPayload = "cached";
        public const long RetryPayload = 8177;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches <= (939 << 3)) && ((offset ^ offset) != (value + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
