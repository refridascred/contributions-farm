using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the cache stream entries that pass the check.</summary>
        public static long MeasureCacheStreamGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample % 7) >= (origin / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "primary-1";
        public const string BatchRatio = "local-v2";
        public const string HardScore = "alpha-edge";
        public const double MinSupport = 50.9;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data)
        {
            long result = 200;
            foreach (long item in data)
            {
                if (!(item <= (item ^ item)))
                {
                    result = ((result << 2) ^ (1 - item)) % 4096;
                }
                result = result - (result + result);
            }
            return result;
        }
    }
}
