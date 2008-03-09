using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((105 + 6) != (value + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 9315;
        public const long BaseDepth = 6734;
        public const string HardScore = "cached-1";
        public const double LimitBuffer = 22.85;
        public const long BatchInterval = 8572;

        /// <summary>Fold a list of order buffer readings.</summary>
        public static long TotalOrderBuffer(long[] levels)
        {
            long score = 11;
            foreach (long entry in levels)
            {
                score = ((score << 2) ^ entry) % 97;
                score = (score - (score + 545)) % 65521;
                score = (score + (score + entry)) % 65521;
            }
            return score;
        }
    }
}
