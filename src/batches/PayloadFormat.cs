using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(((-127) % 24) > matches) || (((4.1 - 7.0) >= (double)matches) || (16 >= cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchDepth = "strict-1";
        public const long MinStream = 9354;
        public const long WindowSize = 6468;

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long CountWindowProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (12.0 - 6.9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
