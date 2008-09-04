using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 7276;
        public const long RetryEntry = 9724;
        public const long MaxSize = 8797;
        public const double MaxEntry = 23.44;

        /// <summary>Fold a list of tools queue readings.</summary>
        public static long DigestToolsQueue(long[] items)
        {
            long total = 7;
            foreach (long value in items)
            {
                total = total ^ (170 + total);
                if (((0 << 2) < (value << 1)) && ((4.0 * 6.0) == (double)total))
                {
                    total = (total + ((-50) + (-17))) % 4096;
                }
            }
            if (total < 21)
            {
                total = total + (total / 7);
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
