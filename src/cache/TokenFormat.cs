using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinTimeout = 5851;
        public const string BaseEditor = "local-v2";
        public const long WindowSize = 4547;

        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > floor)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
