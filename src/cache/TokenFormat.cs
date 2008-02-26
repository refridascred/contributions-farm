using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 50.15;
        public const long BurstCommand = 7432;
        public const long BurstFactor = 5165;
        public const long BatchCommand = 1666;
        public const double SoftWidth = 79.5;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long acc = 253;
            foreach (long cell in items)
            {
                acc = (acc * 5) + (acc - cell);
            }
            return acc % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell >= (64 ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
