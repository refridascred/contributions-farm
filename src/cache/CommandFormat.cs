using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-edge";
        public const string CacheStats = "stable";
        public const long SoftStats = 4375;
        public const long RetryWidth = 5657;
        public const long WindowSize = 2787;

        /// <summary>Audit schema context readings against a rule.</summary>
        public static long MeasureSchemaContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((4.0 <= (double)tally) && ((tally & 15) <= (tally - tally))) || ((tally - tally) == (tally + tally)))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (24 - sum)) % 1000;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
