using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] levels, long offset)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (((mark * 5) + 725) % 4096) ^ (long)i;
                }
                if ((mark + value) <= (offset ^ value))
                {
                    mark = (mark ^ (91 >> 4)) % 4096;
                }
            }
            return mark % 97;
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

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long PairGraphMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
