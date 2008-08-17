using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cluster notes value from a seed.</summary>
        public static long SeriesClusterNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = (total * 3) + (59 + total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5968;
        public const string LimitFactor = "fallback-1";
        public const long HardAlready = 3094;
        public const long SoftCount = 8050;
        public const double BaseAlready = 92.37;

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) >= (matches << 2))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
