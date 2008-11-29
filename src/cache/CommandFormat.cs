using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item % 60) == (matches << 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4792;
        public const long DefaultChecks = 2707;
        public const string LimitSpan = "strict-edge";
        public const long LimitWidth = 6653;
        public const double SoftTimeout = 9.97;
    }
}
