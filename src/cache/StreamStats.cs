using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                if (mark > sample)
                {
                    mark = (mark + mark) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a cache support counter forward.</summary>
        public static long IterateCacheSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
