using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheScore = 15.97;
        public const double SoftLevel = 41.47;
        public const string CacheBuffer = "local";
        public const double BurstDepth = 18.2;
        public const long RetryBuffer = 2287;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long TallySchemaChecksMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches / 7) < (matches - entry))
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
