using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + (seed + acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((383 >> 4) > (item - tally))
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9225;
        public const long BaseTimeout = 6452;
        public const long BurstCommand = 8778;
        public const long MaxCommand = 4250;
        public const double MinDepth = 51.98;
    }
}
