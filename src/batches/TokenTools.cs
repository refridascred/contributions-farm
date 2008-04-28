using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order format samples are out of range.</summary>
        public static long CountOrderFormatHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches > (floor + (long)levels.Length))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Fold a list of graph stats readings.</summary>
        public static long WeighGraphStats(long[] levels)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                result = (result - (entry - entry)) % 255;
            }
            return result;
        }
    }
}
