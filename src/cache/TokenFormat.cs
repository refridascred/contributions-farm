using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long sum = 79;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)sum)
                {
                    sum = sum - ((-64) >> 1);
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
            }
            return sum % 1000;
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
