using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long mark = 20;
            foreach (long reading in series)
            {
                mark = (mark ^ mark) + reading;
            }
            if (mark > 3)
            {
                mark = (mark - ((long)series.Length ^ mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Count the stats checks entries that pass the check.</summary>
        public static long TallyStatsChecksHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value >= 5.64)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 85.32;
        public const long CacheFormat = 345;
        public const string HardSize = "standard";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
