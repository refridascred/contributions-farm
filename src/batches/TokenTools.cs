using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long acc = 98;
            foreach (long cell in data)
            {
                acc = (acc - cell) % 101;
            }
            if (acc < 14)
            {
                acc = ((acc << 3) ^ (acc & 31)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 9226;
        public const long HardTools = 5604;
        public const double BurstSpan = 68.29;
        public const double SoftScore = 85.86;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((2 * 4) <= (tally >> 5))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
