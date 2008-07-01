using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 39.84;
        public const long BaseScore = 7786;
        public const double CacheChannel = 93.07;
        public const double MaxChannel = 34.61;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value << 2) < (tally * 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result + target) % 1000;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result - ((long)i + result)) - (long)i2;
                }
                result = result - (target & 1);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 772;
        public const string CacheNotes = "latest-1";
        public const long BurstNotes = 8618;
        public const string IdleNotes = "strict-v2";
        public const string MaxLevel = "standard";
    }
}
