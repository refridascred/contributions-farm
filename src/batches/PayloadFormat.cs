using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSpan = 5862;
        public const long DefaultWidth = 2468;
        public const long BurstAlready = 9383;
        public const long LimitLevel = 3367;

        /// <summary>Check that every metric profile entry stays within the limit.</summary>
        public static bool GuardMetricProfileRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
