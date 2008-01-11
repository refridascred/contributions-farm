using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches < sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
