using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 3584;
        public const double HardFactor = 32.22;
        public const long IdleChecks = 4593;
        public const long BurstCount = 3460;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally < seed) && (((tally & 63) < 257) && (47 >= (tally & 1))))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (offset << 3)) % 255;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
